using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    public string tag;

    public int price;

    void Start()
    {
        UpdateThingCounter(1);
    }
    
    public void SetParent(Transform newParent)
    {
        transform.position = newParent.position;
        transform.parent = newParent;
    }

    public void NullParent()
    {
        transform.parent = null;
    }

    void UpdateThingCounter(int value)
    {
        GameObject.FindGameObjectWithTag("Helper").GetComponent<Text>().text = "";
        if (Mathf.Abs(value) != 1)
        {
            value = 0;
        }
        if (tag == "Trash")
        {
            Camera.main.GetComponent<TotalThings>().Trash += value;

        }
        else if (tag == "Family Thing")
        {

            Camera.main.GetComponent<TotalThings>().FamilyThing += value;
        }
        Camera.main.GetComponent<TotalThings>().UpdateText();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Shop")
        {
            Camera.main.GetComponent<CashScript>().UpdateCash(price);
            UpdateThingCounter(-1);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Chest")
        {

            UpdateThingCounter(-1);
            
            Destroy(gameObject);
        }
    }
}
