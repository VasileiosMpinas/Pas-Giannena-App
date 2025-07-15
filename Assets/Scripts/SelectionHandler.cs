using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectionHandler : MonoBehaviour
{
    [SerializeField] GameObject[] selectionFields;

    string[] labels = { "Coffee", "Brunch", "Bars&Pubs", "Nightlife", "Fast Food", "Casual Dining", "Fine Dining",
                        "Nature", "Education", "Shopping", "Movies&Theater", "Games", "Sports"};

    public void moveToPlanPage()
    {
        string tags = "";
        for (int i = 0; i < selectionFields.Length; i++)
        {
            if (selectionFields[i].GetComponent<Toggle>().isOn)
            {
                tags += labels[i] + ",";
            }
        }


        if (tags.Length != 0) { tags = tags.Substring(0, tags.Length - 1); }


        PlayerPrefs.SetString("tags", tags);
        SceneManager.LoadScene("ProgramScene");
    }


}
