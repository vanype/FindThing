using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHelper : MonoBehaviour
{
    Text helperText;
    void Start()
    {
        helperText = GameObject.FindGameObjectWithTag("Helper").GetComponent<Text>();
    }
    
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Object")
        {
            helperText.text = other.GetComponent<Object>().tag;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Object")
        {
            helperText.text = "";
        }
    }

    
}
