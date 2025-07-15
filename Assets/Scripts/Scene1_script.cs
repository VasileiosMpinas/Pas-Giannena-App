using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1_script : MonoBehaviour
{
    int allday_counter=0;
    int[] hours_list=new int[7] {0,0,0,0,0,0,0};
    int general_counter=0;


    public Button Button_Allday;

    public Button Button_sunrise;
    public Button Button_morning;
    public Button Button_noon;
    public Button Button_afternoon;
    public Button Button_evening;
    public Button Button_night;
    public Button Button_latenight;


    public Button Button_next;
    public Button Button_prev;


    // All Day Plan Button
    public void Press_Button_Allday()
    {   
        allday_counter++;
        if (allday_counter==1){
            general_counter++;
            Button_sunrise.enabled=false;
            Button_morning.enabled=false;
            Button_noon.enabled=false;
            Button_afternoon.enabled=false;
            Button_evening.enabled=false;
            Button_night.enabled=false;
            Button_latenight.enabled=false;
        }

        else if (allday_counter==2){

            general_counter--;
            allday_counter=0;
            Button_sunrise.enabled=true;
            Button_morning.enabled=true;
            Button_noon.enabled=true;
            Button_afternoon.enabled=true;
            Button_evening.enabled=true;
            Button_night.enabled=true;
            Button_latenight.enabled=true;
        }
    
    }

    // Hours of the day buttons
    public void Press_Button_sunrise()
    {   
        hours_list[0]++;

        if (hours_list[0]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[0]==2){
            general_counter--;
            hours_list[0]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_morning()
    {   
        hours_list[1]++;

        if (hours_list[1]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[1]==2){
            general_counter--;
            hours_list[1]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_noon()
    {   
        hours_list[2]++;

        if (hours_list[2]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[2]==2){
            general_counter--;
            hours_list[2]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_afternoon()
    {   
        hours_list[3]++;

        if (hours_list[3]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[3]==2){
            general_counter--;
            hours_list[3]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_evening()
    {   
        hours_list[4]++;

        if (hours_list[4]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[4]==2){
            general_counter--;
            hours_list[4]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_night()
    {   
        hours_list[5]++;

        if (hours_list[5]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[5]==2){
            general_counter--;
            hours_list[5]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }

    public void Press_Button_latenight()
    {   
        hours_list[6]++;

        if (hours_list[6]==1){
            general_counter++;
            Button_Allday.enabled=false;
        }
        else if (hours_list[6]==2){
            general_counter--;
            hours_list[6]=0;
        
            if(hours_list[0]==0 && hours_list[1]==0 && hours_list[2]==0 && hours_list[3]==0 && hours_list[4]==0 && hours_list[5]==0 && hours_list[6]==0){
                Button_Allday.enabled=true;
            }
        
        }
    
    }



    // Go to the next or previous scene

    public void Press_Button_changeScene(){
        PlayerPrefs.SetInt("ALL DAY PLAN",allday_counter);
        PlayerPrefs.SetInt("Sunrise",hours_list[0]);
        PlayerPrefs.SetInt("Morning",hours_list[1]);
        PlayerPrefs.SetInt("Noon",hours_list[2]);
        PlayerPrefs.SetInt("Afternoon",hours_list[3]);
        PlayerPrefs.SetInt("Evening",hours_list[4]);
        PlayerPrefs.SetInt("Night",hours_list[5]);
        PlayerPrefs.SetInt("Late-night",hours_list[6]);
        PlayerPrefs.Save();
        //GoToScene(prevScene);
        //GoToScene(nextScene);
    }


    public void GoToScene(){//string sceneName
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    
    // Start is called before the first frame update
    void Start()
    {
        
        allday_counter = PlayerPrefs.GetInt("ALL DAY PLAN",allday_counter);
        hours_list = new int[7] {
            PlayerPrefs.GetInt("Sunrise",hours_list[0]),
            PlayerPrefs.GetInt("Morning",hours_list[1]),
            PlayerPrefs.GetInt("Noon",hours_list[2]),
            PlayerPrefs.GetInt("Afternoon",hours_list[3]),
            PlayerPrefs.GetInt("Evening",hours_list[4]),
            PlayerPrefs.GetInt("Night",hours_list[5]),
            PlayerPrefs.GetInt("Late-night",hours_list[6]),
        };
        Button_next.enabled=false;
        Button_prev.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(general_counter>=1){

            Button_next.enabled=true;
            Button_prev.enabled=true;

        }else{

            Button_next.enabled=false;
            Button_prev.enabled=false;

        }
    }
}
