using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldSave : MonoBehaviour
{
    public TMP_InputField InputField_Fname;
    public TMP_InputField InputField_Lname;
    public TMP_InputField InputField_Bname;
    public TMP_InputField InputField_Address;
    public TMP_InputField InputField_Description;
    public TMP_InputField InputField_Zip_Code;


    string[] InputFieldSaves_list=new string[6] {"","","","","",""};



    public void Save_ALL_InputField()
    {
        InputFieldSaves_list[0]=InputField_Fname.text;
        PlayerPrefs.SetString("InputField_Fname",InputFieldSaves_list[0]);

        InputFieldSaves_list[1]=InputField_Lname.text;
        PlayerPrefs.SetString("InputField_Lname",InputFieldSaves_list[1]);

        InputFieldSaves_list[2]=InputField_Bname.text;
        PlayerPrefs.SetString("InputField_Bname",InputFieldSaves_list[2]);

        InputFieldSaves_list[3]=InputField_Address.text;
        PlayerPrefs.SetString("InputField_Address",InputFieldSaves_list[3]);

        InputFieldSaves_list[4]=InputField_Description.text;
        PlayerPrefs.SetString("InputField_Description",InputFieldSaves_list[4]);


        InputFieldSaves_list[5]=InputField_Zip_Code.text;
        PlayerPrefs.SetString("InputField_Zip_Code",InputFieldSaves_list[5]);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
