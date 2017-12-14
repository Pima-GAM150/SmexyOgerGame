using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwap : MonoBehaviour {

    public Camera CamUI;
    public Camera CamL;
    public Camera CamR;
    public GameObject Oni1;
    public GameObject Oni2;
    public PlayerSettings settings;
    private Vector3 VectorL = new Vector3(-2.5f, 15, 2.6f);
    private Vector3 VectorR = new Vector3(2.5f, 15, 2.6f);
    private Vector3 Euler = new Vector3(0f, 0f, 0f);

	// Use this for initialization
	void Start () {
        CamUI.enabled = true;
        CamL.enabled = false;
        CamR.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame() {
        CamUI.enabled = false;
        CamL.enabled = true;
        CamR.enabled = true;
    }

    public void SwapPlayerCam() {
        //Debug.Log(settings.GetComponent<PlayerSettings>().getTeam());
        if (settings.GetComponent<PlayerSettings>().getTeam() == 1) {
            CamL.transform.parent = Oni1.transform;
            CamR.transform.parent = Oni1.transform;   
        }
        else {//player 2
            CamL.transform.parent = Oni2.transform;
            CamR.transform.parent = Oni2.transform;
        }
        CamL.transform.localPosition = VectorL;
        CamR.transform.localPosition = VectorR;
        CamL.transform.localEulerAngles = Euler;
        CamR.transform.localEulerAngles = Euler;
    }
}
