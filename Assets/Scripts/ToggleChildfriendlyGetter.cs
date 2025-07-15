using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChildfriendlyGetter : MonoBehaviour
{
    public GameObject togglerForChildren;
    public bool wantChildfriendly = false;

    void Start()
    {
        PlayerPrefs.SetInt("wantChildfriendly", wantChildfriendly ? 1 : 0);
        //PlayerPrefs.Save();
        //print(toggler.GetComponent<Toggle>().isOn);
    }

    public void SetChildfriendly (bool isChildfriendly)
    {
        if (isChildfriendly)
        {
            wantChildfriendly = true;
        }
        else 
        {
            wantChildfriendly = false;
        }
        PlayerPrefs.SetInt("wantChildfriendly", wantChildfriendly ? 1 : 0);
        PlayerPrefs.Save();
    }
}
