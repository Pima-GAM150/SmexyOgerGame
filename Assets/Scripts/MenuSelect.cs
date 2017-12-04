using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuSelect : MonoBehaviour {
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas CreditsCanvas;
    
    void Awake()
    {
        OptionsCanvas.enabled = false;
        CreditsCanvas.enabled = false;
    }
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
        CreditsCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
        CreditsCanvas.enabled = false;
    }
    public void CreditsOn()
    {
        CreditsCanvas.enabled = true;
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
    }
    
    //use to load start game
    //public void LoadOn()
    //{
      //  Application.LoadLevel(put name of scene here);
    //}
}
