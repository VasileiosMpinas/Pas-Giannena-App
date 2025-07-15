using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ScrollViewMapManager : MonoBehaviour
{
    public TMP_Text TextComponent;
    public Image ImageComponent;
    public List<string> NameList;
    public List<string> AddressList;
    public List<float> RatingList;
    public TutorialScrollView script;
    [SerializeField] public GameObject[] allPanels;
    [SerializeField] public Sprite[] photos;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        script = GameObject.FindWithTag("listOfPlaces").GetComponent<TutorialScrollView>();
        NameList = script.GetListOfNames();
        AddressList = script.GetListOfAddresses();
        RatingList = script.GetListOfRatings();

        Debug.Log(" NameList length: " + NameList.Count);
        Debug.Log(" AddressList length: " + AddressList.Count);
        int i = 0;
        foreach (GameObject panel in allPanels)
        {
            if (i == 14 | i == 29 | i == 66)
            {
                i = i + 1;
            }
            if (i == 39) {
                i = i + 5;
            }
            if (i == 63)
            {
                i = i + 4;
            }
            GameObject child1 = panel.transform.GetChild(0).gameObject; //Text
            GameObject child2 = panel.transform.GetChild(1).gameObject; //Image
            TextComponent = child1.GetComponent<TextMeshProUGUI>();
            TextComponent.text = NameList[i] + "\nAddress: " + AddressList[i] +"\nRating: "+ RatingList[i] + " Stars";
            ImageComponent = child2.GetComponent<Image>();
            ImageComponent.sprite = photos[i];
            i++;
        }
    }

    public GameObject[] GetPanels()
    {
        return this.allPanels;
    }

    public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");
    }

}