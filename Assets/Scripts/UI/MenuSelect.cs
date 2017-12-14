using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuSelect : MonoBehaviour {
    public PlayerSettings playerSettings;
    public GameObject GameUI;
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas CreditsCanvas;
    public Canvas TitleCanvas;
    public CamSwap camSwap;
    
    void Awake()
    {
        MainCanvas.enabled = true;
        OptionsCanvas.enabled = false;
        CreditsCanvas.enabled = false;
        TitleCanvas.enabled = true;
        GameUI.SetActive(false);
        Time.timeScale = 0;
    }
    public void OptionsOn()
    {
        MainCanvas.enabled = false;
        OptionsCanvas.enabled = true;
        CreditsCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        MainCanvas.enabled = true;
        OptionsCanvas.enabled = false;
        CreditsCanvas.enabled = false;
    }
    public void CreditsOn()
    {
        MainCanvas.enabled = false;
        CreditsCanvas.enabled = true;
        OptionsCanvas.enabled = false;
    }
    public void StartGame() {
        MainCanvas.enabled = false;
        CreditsCanvas.enabled = false;
        OptionsCanvas.enabled = false;
        TitleCanvas.enabled = false;
        playerSettings.GetComponent<PlayerSettings>().nGame();
        camSwap.GetComponent<CamSwap>().StartGame();
        GameUI.SetActive(true);
        Time.timeScale = 1;
    }
}
