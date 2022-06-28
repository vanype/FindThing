using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalThings : MonoBehaviour
{
    public int FamilyThing;
    public int Trash;
    Text ThingsAndTrash;

    
    void Start()
    {
        ThingsAndTrash = GameObject.FindGameObjectWithTag("Things&Trash").GetComponent<Text>();
        
    }
    public void UpdateText()
    {
        ThingsAndTrash.text = ("Trash left:" + Trash + "\n" + "Family Things left:" + FamilyThing);
        if(Trash == 0 && FamilyThing == 0)
        {
            LevelController.Win();
        }
    }
}
