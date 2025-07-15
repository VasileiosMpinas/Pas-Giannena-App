using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{
    public void ChangeLocale(int localeID)
    {
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int localeID){
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];

    }
  
}
