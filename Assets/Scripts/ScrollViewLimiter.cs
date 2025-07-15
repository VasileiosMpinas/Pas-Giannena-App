using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewLimiter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //print(GetComponent<ScrollRect>().content.transform.position);
        GetComponent<ScrollRect>().onValueChanged.AddListener(onScroll);
    }

    void onScroll(Vector2 value)
    {
        print(value);
    }
}
