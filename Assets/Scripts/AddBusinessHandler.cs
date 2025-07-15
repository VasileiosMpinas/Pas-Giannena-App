using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class AddBusinessHandler : MonoBehaviour
{
    [SerializeField] TextAsset toBeAddedList; //To be checked by unpaid interns

    [SerializeField] GameObject[] textFields;
    [SerializeField] GameObject[] sliderFields;
    [SerializeField] GameObject[] checkBoxFields;

    string[] textFieldNames = {"FirstName", "LastName", "BusinessName", "Address","Description","ZipCode"};
    string[] sliderFieldNames = { "PriceRange", "Rating"};
    string[] checkboxFieldNames = { "FamilyFriendly", "Accessible", "FineDining", "Nightlife", "Fast Food", "Education",
                                    "Nature", "Shopping", "Brunch", "Coffee", "Casual Dining", "Bars&Pubs", "Games", "Cinema&Theater"};

    public void addBusiness()
    {
        string businessInfo = "";

        for (int i = 0; i < textFields.Length; i++)
        {
            businessInfo += textFieldNames[i] + ":" + textFields[i].GetComponent<TMP_InputField>().text + ",";
        }

        for (int i = 0; i < sliderFields.Length; i++)
        {
            businessInfo += sliderFieldNames[i] + ":" + sliderFields[i].GetComponent<Slider>().value + ",";
        }

        businessInfo += "Tags:[";

        for (int i = 0; i < textFields.Length; i++)
        {
            if (checkBoxFields[i].GetComponent<Toggle>().isOn)
            {
                businessInfo += checkboxFieldNames[i] + ",";
            }
        }
        businessInfo = businessInfo.Substring(0, businessInfo.Length - 1) + "]";
        print(businessInfo);

    }


}
