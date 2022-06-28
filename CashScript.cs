using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashScript : MonoBehaviour
{
    int cash;
    Text cashText;
    void Start()
    {
        cashText = GameObject.FindGameObjectWithTag("CashText").GetComponent<Text>();
    }
    public void UpdateCash(int offsetCash)
    {
        cash += offsetCash;
        cashText.text = ("Cash:" + cash.ToString());
    }
}
