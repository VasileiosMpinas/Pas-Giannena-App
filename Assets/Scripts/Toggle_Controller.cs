using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Controller : MonoBehaviour
{
    int[] toggle_list=new int[14] {0,0,0,0,0,0,0,0,0,0,0,0,0,0};

    public Toggle Toggle_FamilyFriendly;
    public Toggle Toggle_Accessible;
    public Toggle Toggle_FineDining;
    public Toggle Toggle_NightLife;
    public Toggle Toggle_FastFood;
    public Toggle Toggle_Education;
    public Toggle Toggle_Reconnecting;
    public Toggle Toggle_Shopping;
    public Toggle Toggle_Brunch;
    public Toggle Toggle_coffee;
    public Toggle Toggle_CasualDining;
    public Toggle Toggle_BarsPubs;
    public Toggle Toggle_Games;
    public Toggle Toggle_CinemaTheatre;

    public void FamilyFriendly()
    {
        toggle_list[0]++;

        if (toggle_list[0]==2){
            toggle_list[0]=0;
        }
    }

    public void Accessible()
    {
        toggle_list[1]++;

        if (toggle_list[1]==2){
            toggle_list[1]=0;
        }
    }

    public void FineDining()
    {
        toggle_list[2]++;

        if (toggle_list[2]==2){
            toggle_list[2]=0;
        }
    }

    
    public void NightLife()
    {
        toggle_list[3]++;

        if (toggle_list[3]==2){
            toggle_list[3]=0;
        }
    }


    public void FastFood()
    {
        toggle_list[4]++;

        if (toggle_list[4]==2){
            toggle_list[4]=0;
        }
    }


    public void Education()
    {
        toggle_list[5]++;

        if (toggle_list[5]==2){
            toggle_list[5]=0;
        }
    }


    public void Reconnecting()
    {
        toggle_list[6]++;

        if (toggle_list[6]==2){
            toggle_list[6]=0;
        }
    }  


    public void Shopping()
    {
        toggle_list[7]++;

        if (toggle_list[7]==2){
            toggle_list[7]=0;
        }
    }  

    public void Brunch()
    {
        toggle_list[8]++;

        if (toggle_list[8]==2){
            toggle_list[8]=0;
        }
    }
    

    public void coffee()
    {
        toggle_list[9]++;

        if (toggle_list[9]==2){
            toggle_list[9]=0;
        }
    }

    public void CasualDining()
    {
        toggle_list[10]++;

        if (toggle_list[10]==2){
            toggle_list[10]=0;
        }
    }

    public void BarsPubs()
    {
        toggle_list[11]++;

        if (toggle_list[11]==2){
            toggle_list[11]=0;
        }
    }

    public void Games()
    {
        toggle_list[12]++;

        if (toggle_list[12]==2){
            toggle_list[12]=0;
        }
    }

    public void CinemaTheatre()
    {
        toggle_list[13]++;

        if (toggle_list[13]==2){
            toggle_list[13]=0;
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        Toggle_FamilyFriendly.isOn = false;
        Toggle_Accessible.isOn = false;
        Toggle_FineDining.isOn = false;
        Toggle_NightLife.isOn = false;
        Toggle_FastFood.isOn = false;
        Toggle_Education.isOn = false;
        Toggle_Reconnecting.isOn = false;
        Toggle_Shopping.isOn = false;
        Toggle_Brunch.isOn = false;
        Toggle_coffee.isOn = false;
        Toggle_CasualDining.isOn = false;
        Toggle_BarsPubs.isOn = false;
        Toggle_Games.isOn = false;
        Toggle_CinemaTheatre.isOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
