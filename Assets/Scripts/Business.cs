using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Business
{
    public string Name;
    public string Address;
    public int Price_Range;
    public float Stars;
    public int For_Children;
    public int Accessible;
    public string Description;
    public string Hours;
    public string[] Tags;

    public int[] workPeriods = { 0, 0, 0, 0, 0, 0, 0 };
    public int id = -1;


    public void setUp(int id)
    {
        this.id = id;
        if (Hours == "X") 
        { 
            for (int i = 0; i < 7; i++) { workPeriods[i] = 1; }
            return;
        }

        string[] spl = Hours.Split("-");
        int start = int.Parse(spl[0]);
        int end = int.Parse(spl[1]);

        while (end != start)
        {
            if (start >= 6 && start <= 9) { workPeriods[0] += 1; }
            else if (start >= 9 && start <= 12) { workPeriods[1] += 1; }
            else if (start >= 12 && start <= 16) { workPeriods[2] += 1; }
            else if (start >= 16 && start <= 18) { workPeriods[3] += 1; }
            else if (start >= 18 && start <= 21) { workPeriods[4] += 1; }
            else if (start >= 21 && start <= 24) { workPeriods[5] += 1; }
            else if (start >= 0 && start <= 6) { workPeriods[6] += 1; }

            start += 1;
            if (start == 25) { start = 1; }
        }

        for (int i = 0; i < 7; i++)
        { 
            if (workPeriods[i] == 1) { workPeriods[i] = 0; }
            else { workPeriods[i] = 1; }
        }
    }

    public string toString()
    {

        string tags = "";
        foreach (string i in Tags) { tags += i + ","; }

        return Name + ";" + Address + ";" + Price_Range + ";" + Stars + ";" + For_Children
                + ";" + Accessible + "," + Description + ";" + Hours + ";" + tags.Substring(0,tags.Length-1);
    }

}
