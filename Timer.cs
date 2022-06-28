using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText;
    public int time;
    
    void Start()
    {
        timerText = GameObject.FindGameObjectWithTag("TimerText").GetComponent<Text>();
        if (time > 0)
        {
            StartCoroutine(timer());
        }   
        
    }
    IEnumerator timer()
    {
        
        int sec = time;
        
        while (sec > 0)
        {
            timerText.text = ("Time left:"+sec.ToString());
            yield return new WaitForSeconds(1);
            sec--;

        }
        LevelController.Lose();
    }
}
