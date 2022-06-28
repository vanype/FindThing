using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjToHand : MonoBehaviour
{
    GameObject inHandObject;
    public GameObject Hand;
    bool HasObjectInHand = false;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Object")
        {
            
            if (Input.GetKey(KeyCode.E))
            {
                HasObjectInHand = CheckHand();
                if (!HasObjectInHand)
                {
                    HasObjectInHand = true;
                    other.gameObject.GetComponent<Object>().SetParent(Hand.transform);
                    other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                    other.gameObject.GetComponent<Collider>().isTrigger = true;
                   // other.gameObject.transform.localScale = other.gameObject.transform.localScale / 3;
                }
                
                
                
            }
           
        }
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HasObjectInHand = CheckHand();
            if (HasObjectInHand)
            {
                Hand.GetComponentInChildren<Collider>().isTrigger = false;
              //Hand.GetComponentInChildren<Transform>().localScale = Hand.GetComponentInChildren<Transform>().localScale * 3;
                Hand.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.None;
                Hand.GetComponentInChildren<Object>().NullParent();


                HasObjectInHand = false;
            }
        }

    }
    bool CheckHand()
    {
        if (Hand.transform.childCount > 0)
        {
            return true;
        }
        return false;
    }
}
