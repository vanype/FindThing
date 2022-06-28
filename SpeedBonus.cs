using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    public int Bonus;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<FirstPersonController>().StartBonus(Bonus);
            Destroy(gameObject);
        }
    }
    
   
}
