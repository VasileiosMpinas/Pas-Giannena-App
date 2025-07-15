using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization.Settings;

public class DropdownManager : MonoBehaviour
{
    [SerializeField] protected TMP_Dropdown dropdown;
    
    public void Start()//
    {
        //LocalizationSettings.AvailableLocales.Locales[0];
        Debug.Log(LocalizationSettings.AvailableLocales.Locales[0]);
        Debug.Log(LocalizationSettings.AvailableLocales.Locales[1]);
        Debug.Log("___________");
    }

    public void SelectedText()
    {
        Debug.Log(dropdown.value);
        Debug.Log(dropdown.options[dropdown.value].text);
    }

    public void OnDropdownChanged(TMP_Dropdown dropdown)
    {
        SelectedText();//
        ChangeLocale(dropdown.value);
    }

    public void ChangeLocale(int localeID)
    {
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];

    }
}


    