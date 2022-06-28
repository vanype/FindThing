using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    static GameObject MainUI;
    static GameObject WinUI;
    static GameObject LoseUI;

    void Start()
    {

        MainUI = GameObject.FindGameObjectWithTag("MainUI");
        WinUI = GameObject.FindGameObjectWithTag("WinUI");
        LoseUI = GameObject.FindGameObjectWithTag("LoseUI");
        WinUI.SetActive(false);
        LoseUI.SetActive(false);

    }

    public static void Win()
    {

        MainUI.SetActive(false);
        WinUI.SetActive(true);

        Time.timeScale = 0;

        Camera.main.GetComponentInParent<FirstPersonController>().cameraCanMove = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public static void Lose()
    {

        MainUI.SetActive(false);
        LoseUI.SetActive(true);

        Time.timeScale = 0;

        Camera.main.GetComponentInParent<FirstPersonController>().cameraCanMove = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
}
