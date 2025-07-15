using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    private string Name;
    public int Number;
    public Text ButtonText;
    public TutorialScrollView ScrollView;

    public void SetName(int number, string name)
    {
        Name = name;
        Number = number+1;
        ButtonText.text = name;
    }
    public void Button_Click()
    {
        ScrollView.ButtonClicked(Name);
        Debug.Log(Number);
    }
}
