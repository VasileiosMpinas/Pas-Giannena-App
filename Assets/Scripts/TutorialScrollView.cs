using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TutorialScrollView : MonoBehaviour
{

    public GameObject Button_Template;
    public TextAsset jsonData;
    //public TextAsset jsonDataGR;
    public ListOfBusinesses mylistOfBusinesses = new ListOfBusinesses();
    public GameObject[] panels;
    [SerializeField] public List<string> NameList;
    [SerializeField] public List<string> AddressList;
    [SerializeField] public List<float> RatingList;

    [System.Serializable]
    public class Business
    {
        public string Name;
        public string Address;
        public int Price_Range;
        public float Stars;
        public int For_Children;
        public int Accessible;
        public string Description;
        public string Hours;
        public Tag[] Tags;
    }

    [System.Serializable]
    public class Tag
    {
        public List<string> tags;
    }

    [System.Serializable]
    public class ListOfBusinesses
    {
        public Business[] businesses;
    }

   
    void Awake()
    {
        int j = 1;
        NameList ??= new List<string>();
        AddressList ??= new List<string>();

        /*if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0])
        {
            ListOfBusinesses mylistOfBusinesses = JsonUtility.FromJson<ListOfBusinesses>(jsonDataEN.text);
        }
        else {
            ListOfBusinesses mylistOfBusinesses = JsonUtility.FromJson<ListOfBusinesses>(jsonDataGR.text);
        }*/
        mylistOfBusinesses = JsonUtility.FromJson<ListOfBusinesses>(jsonData.text);
        Debug.Log(" mylistOfBusinesses.businesses.Length: " + mylistOfBusinesses.businesses.Length);
        if (NameList.Count != mylistOfBusinesses.businesses.Length)
        {
            for (int i = 0; i < mylistOfBusinesses.businesses.Length; i++)
            {
                string store_name = j + ". " + mylistOfBusinesses.businesses[i].Name;
                NameList.Add(mylistOfBusinesses.businesses[i].Name);
                AddressList.Add(mylistOfBusinesses.businesses[i].Address);
                RatingList.Add(mylistOfBusinesses.businesses[i].Stars);
                GameObject go = Instantiate(Button_Template) as GameObject;
                go.SetActive(true);
                ButtonManager TB = go.GetComponent<ButtonManager>();
                TB.SetName(i, store_name);
                go.transform.SetParent(Button_Template.transform.parent);
                j++;
            }
        }
    }

    public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");
    }

    public List<string> GetListOfNames() 
    {
        return this.NameList;
    }

    public List<string> GetListOfAddresses()
    {
        return this.AddressList;
    }

    public List<float> GetListOfRatings()
    {
        return this.RatingList;
    }
}