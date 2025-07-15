using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpHandler : MonoBehaviour
{

    [SerializeField] GameObject[] helpSequence;
    int sequenceIndex = -1;
    bool isHelping = false;


    private void Update()
    {
        if (!isHelping) return;
        if (Input.GetMouseButtonUp(0))
        {
            moveSequence();
        }
    }


    public void startHelpSequence()
    {
        isHelping = true;
        GetComponent<Image>().enabled = true;
        moveSequence();
    }

    void moveSequence()
    {
        if (sequenceIndex >= 0) helpSequence[sequenceIndex].SetActive(false);
        sequenceIndex++;


        if (sequenceIndex >= helpSequence.Length)
        {
            isHelping = false;
            sequenceIndex = -1;
            GetComponent<Image>().enabled = false;
            return;
        }

        helpSequence[sequenceIndex].SetActive(true);
    }
}
