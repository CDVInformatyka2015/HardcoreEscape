﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour {

    private bool pressKeyState;

    void Update()
    {
        if (pressKeyState)
        {
            foreach (KeyCode vKey in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(vKey))
                {
                    GameObject.Find("ButtonKey").GetComponentInChildren<Text>().text = "Klawisz:" + vKey;
                    PlayerPrefs.SetString("jumpKey", vKey.ToString());
                    pressKeyState = false;
                }
            }
        }
    }
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if (PlayerPrefs.HasKey("audio"))
        {
            if(PlayerPrefs.GetFloat("audio") == 0f)
            {
                TurnOffSound();
            }
        }
        if (PlayerPrefs.HasKey("jumpKey"))
        {
            KeyCode keycode = (KeyCode)Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("jumpKey"));
            GameObject.Find("ButtonKey").GetComponentInChildren<Text>().text = "Klawisz:" + keycode;
        }
    }
    public void ChangeJumpKey()
    {
       GameObject.Find("ButtonKey").GetComponentInChildren<Text>().text = "Wciśnij klawisz";
        pressKeyState = true;
    }
	public void EscapeToGame()
    {
        SceneManager.LoadScene("SuperLabirynth");
    }
    public void EscapeToExit()
    {
        Application.Quit();
    }
    public void TurnOffSound()
    {
        AudioListener.volume = 0f;
        PlayerPrefs.SetFloat("audio", 0f);
        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Włącz dźwięk";
    }
    public void TurnOnSound()
    {
        AudioListener.volume = 1f;
        PlayerPrefs.SetFloat("audio", 1f);
        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Wyłącz dźwięk";
    }
    public void ToggleSound()
    {
        Debug.Log("ToggleSound");
        if (PlayerPrefs.HasKey("audio"))
        {
            if(PlayerPrefs.GetFloat("audio") == 0f)
            {
                TurnOnSound();
            }
            else
            {
                TurnOffSound();
            }
        }
        else
        {
            TurnOffSound();
        }
    }
}
