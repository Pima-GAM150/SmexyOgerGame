using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChangeOption : MonoBehaviour {

    public PlayerSettings timerSet;

    public Text timeSet;
    public Slider timeBar;

    //what are these for? it needs comments
    private int setTime;
    private int timeChange = 120;
    private int minTime = 10;


	// Use this for initialization
	void Start () {

        //this was correct
        PlayerSettings shorter = timerSet.GetComponent<PlayerSettings>();
        //this is used to get the time that is set in the settings
        setTime = shorter.getTimer();
        //and then update the slider to match
        timeBar.value = setTime;
        //timeBar.minValue = timerSet.getTimer();
        
    }
	
	// Update is called once per frame
	void Update () {
        //minTime = shorter.getTimer();
        timeSet.text = ("Time Set: " + setTime);       
        timeBar.maxValue = timeChange;
        timeBar.minValue = minTime;       
    }

    public void changeTime( float newval ) {
        setTime = Mathf.RoundToInt( newval );
        timerSet.setTimer(setTime);
        //timerSet.setTimerFirst(setTime);
    }


}
