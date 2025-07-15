using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slidebar : MonoBehaviour
{

    public Slider slider_price_range;
    public Slider slider_rating;

    public float slider1_value;
    public float slider2_value;


    public void SaveValue()
    {
        
        slider1_value=slider_price_range.value;
        PlayerPrefs.SetFloat("save Price Range",slider1_value);

        slider2_value=slider_rating.value;
        PlayerPrefs.SetFloat("save Rating",slider2_value);
    }
    
    // Start is called before the first frame update
    void Start()
    {

        slider_price_range.value = 0f;
        slider_rating.value = 0f;
    }

}
