using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    int counter = 0;

    //PlayerPrefs
    int[] hoursOfInterest;
    string[] tagsOfInterest;

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartAsAUser()
    {
        SceneManager.LoadScene("Screen2User");
    }

    public void StartAsABusiness()
    {
        SceneManager.LoadScene("Scene6AddBusiness");
    }

    public void Browse()
    {
        SceneManager.LoadScene("ScreenBrowse");
    }

    public void Screen1()
    {
        SceneManager.LoadScene("Screen1");
    }

    public void returnToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void ProgramScene()
    {
        for (int i = 0; i < 7; i++)
        {
            if (hoursOfInterest[i] == 1)
            {
                counter += 1;
                break;
            }
        }

        for (int i = 0; i < 7; i++)
        {
            if (tagsOfInterest[i] != "")
            {
                counter += 1;
                break;
            }
        }

        if (counter == 2)
        {
            SceneManager.LoadScene("ProgramScene");
        }
    }


    void Start()
    {

        tagsOfInterest = PlayerPrefs.GetString("tags").Split(",");

        string[] hours = PlayerPrefs.GetString("hours").Split(",");
        hoursOfInterest = new int[7];
        for (int i = 0; i < 7; i++)
        {
            if (hours[i] == "1")
            {
                hoursOfInterest[i] = 1;
            }
            else
            {
                hoursOfInterest[i] = 0;
            }
        }


    }

}