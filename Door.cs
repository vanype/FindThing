using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float xrot;
    Animator animator;
    bool opened = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "Player" && !opened)
        {
            animator.SetTrigger("Open");
            opened = true;
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        animator.SetTrigger("Close");
        opened = false;
    }
}
