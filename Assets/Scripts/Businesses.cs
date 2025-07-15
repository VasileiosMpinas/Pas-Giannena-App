using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Businesses
{
    public Business[] businesses;



    public void setUp()
    {
        for (int i = 0; i < businesses.Length; i++)
        {
            businesses[i].setUp(i);
        }
        
    }
}
