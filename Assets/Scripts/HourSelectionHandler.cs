using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HourSelectionHandler : MonoBehaviour
{
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject[] buttons;

    int[] selectedHours = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
    bool isFullDayPlan = false;

    Color selectionColor = new Color(115f / 255f, 156f / 255f, 1, 1);
    Color defaultColor = new Color(191f/255f, 153f/255f, 253f/255f, 1);


    /*private void Start()
    {
        string[] hours = PlayerPrefs.GetString("hours").Split(",");
        for (int i = 0; i < 7; i++)
        {
            if (hours[i] == "1")
            {
                selectedHours[i] = 1;
            }
            else
            {
                selectedHours[i] = 0;
            }
        }
        setInteractability();
        changeButtonsState();
    }*/


    public void selectHour(int hour)
    {
        //Special Case; All Day plan
        if (hour == -1)
        {
            isFullDayPlan = !isFullDayPlan;
            if (isFullDayPlan)
            {
                selectedHours = new int[7] { 1, 1, 1, 1, 1, 1, 1 };
            }
            else
            {
                selectedHours = new int[7] {0, 0, 0, 0, 0, 0, 0};
            }
            
        }
        else
        {
            selectedHours[hour] = 1 - selectedHours[hour];
            isFullDayPlan = false;
        }
        setInteractability();
        changeButtonsState();
    }

    void setInteractability()
    {
        foreach (int h in selectedHours)
        {
            if (h == 1) { nextButton.GetComponent<Button>().interactable = true; return; }
        }
        nextButton.GetComponent<Button>().interactable = false;
    }


    void changeButtonsState()
    {
        for (int i = 0; i < 7; i++)
        { 
            if (selectedHours[i] == 1) { buttons[i].GetComponent<Image>().color = selectionColor;  }
            else { buttons[i].GetComponent<Image>().color = defaultColor;  }
        }

        if (isFullDayPlan)
        {
            buttons[7].GetComponent<Image>().color = selectionColor;
        }
        else
        {
            buttons[7].GetComponent<Image>().color = defaultColor;
        }
    }


    public void changeScene(int scene)
    {
        string hours = "";
        for (int i = 0; i < 7; i++)
        {
            hours += selectedHours[i] + ",";
        }
        hours = hours.Substring(0, hours.Length - 1);

        PlayerPrefs.SetString("hours", hours);


        if (scene == 0)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
}
