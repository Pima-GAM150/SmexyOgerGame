using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChangeOption : MonoBehaviour {

    public PlayerSettings timerSet;

    public Text timeSet;
    public Slider timeBar;

    private int setTime;
    private int timeChange;
    private int minTime;


	// Use this for initialization
	void Start () {

        //PlayerSettings shorter = timerSet.GetComponent<PlayerSettings>();
        //setTime = shorter.getTimer();
        //timeChange = setTime;
        setTime = timerSet.getTimer();
        timeChange = 45;
        timeBar.minValue = timerSet.getTimer();
    }
	
	// Update is called once per frame
	void Update () {


        //minTime = shorter.getTimer();

        timeSet.text = ("First Round Time Set: " + setTime);

        
        timeBar.maxValue = timeChange;
        //timeBar.minValue = minTime;
        timerSet.setTimerFirst(setTime);
    }

    public void changeTime( float newval ) {
        setTime = Mathf.RoundToInt( newval );
    }

    
}
