using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChangeOption : MonoBehaviour {

    public PlayerSettings timerSet;

    public Text timeSet;
    public Slider timeBar;


	// Use this for initialization
	void Start () {

        PlayerSettings shorter = timerSet.GetComponent<PlayerSettings>();


    }
	
	// Update is called once per frame
	void Update () {

        PlayerSettings shorter = timerSet.GetComponent<PlayerSettings>();


        timeSet.text = ("First Round Time Set: " + timerSet);

	}
}
