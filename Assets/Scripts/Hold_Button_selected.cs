using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hold_Button_selected : MonoBehaviour
{
    private bool isSelected = false;

    public void SelectButton()
    {
        isSelected = true;
        GetComponent<Button>().interactable = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            GetComponent<Button>().interactable = true;
        }
    }
}
