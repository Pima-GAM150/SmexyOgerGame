using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour {

    public int timeLeft = 10;
    public int currentTime;
    public Text timerCountDown;
    public Slider timeBar;


        // Use this for initialization
    void Start()
    {
        currentTime = timeLeft;
        StartCoroutine("TurnOver");

    }

        // Update is called once per frame
    void Update()
        {

        timerCountDown.text = ("Time: " + timeLeft);

        if (timeLeft <= 0)
            {
                StopCoroutine("TurnOver");
                timerCountDown.text = "Out of Time!";
            }

        //timeBar.maxValue = currentTime.timeLeft;
        //timeBar.value = timeLeft.currentTime;

    }

        IEnumerator TurnOver()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }
        }
    }
