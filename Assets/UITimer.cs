using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour {

    public int timeLeft = 10;
    public int currentTime;
    public Text timerCountDown;
    public Slider timeBarP1;
    public Slider timeBarP2;
    public Transform turnOverUI;

    // Use this for initialization
    void Start()
    {
        currentTime = timeLeft;
        StartCoroutine("TurnOver");

    }

    // Update is called once per frame
    void Update()
    {

        timerCountDown.text = ("Time Left: " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("TurnOver");
            timerCountDown.text = "Out of Time! Switch Oger";
            if (turnOverUI.gameObject.activeInHierarchy == false)
            {
                turnOverUI.gameObject.SetActive(true);
            }
            
        }

        timeBarP1.maxValue = currentTime;
            timeBarP1.value = timeLeft;
            timeBarP2.maxValue = currentTime;
            timeBarP2.value = timeLeft;

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

