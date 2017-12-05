using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIState : MonoBehaviour {//temp script. should be added to PlayerSettings

    public GameObject GameUI;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        GameUI.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void startGame() {
        Time.timeScale = 1;
        GameUI.SetActive(true);
    }
}
