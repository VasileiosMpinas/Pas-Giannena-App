using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAccessibilityGetter : MonoBehaviour
{
    public GameObject togglerForDisabled;
    public bool wantAccessible = false;

    void Start()
    {
        PlayerPrefs.SetInt("wantAccessible", wantAccessible ? 1 : 0);
        //PlayerPrefs.Save();
        //print(toggler.GetComponent<Toggle>().isOn);
    }

    public void SetAccessibility(bool isAccessible)
    {
        if (isAccessible)
        {
            wantAccessible = true;
        }
        else
        {
            wantAccessible = false;
        }
        PlayerPrefs.SetInt("wantAccessible", wantAccessible ? 1 : 0);
        PlayerPrefs.Save();
    }
}
