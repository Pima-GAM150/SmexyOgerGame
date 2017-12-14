using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Alex's script so fk off dont touch! i beleib i do good
public class UITimer : MonoBehaviour {

    private float startTime;
    private float TimeLeft;
    public PlayerSettings playerSet;

    public Text timerCountDown;
    public Slider timeBarP1;
    public Slider timeBarP2;
    public Transform turnOverUI;
    public Text startText;
    public GameObject player1UI;
    public GameObject player2UI;
    public Animator transition;
    public CamSwap camSwap;

    private bool firstRun;

    // Use this for initialization
    void Start()
    {
        // setting timer
        

        PlayerSettings shorter = playerSet.GetComponent<PlayerSettings>();

        //line below is for testing if first turn timer will work. delete later.
        //playerSet.setTimerFirstEnabled(true);
        
        if (shorter.getTimerFirstEnabled())
        {
            startTime = shorter.getTimerFirst();
            firstRun = true;            
        }
        else
            startTime = shorter.getTimer();
            TimeLeft = startTime;
    }
    // Update is called once per frame
    IEnumerator GamePaused(float time) {
        this.enabled = false;
        yield return new WaitForSeconds(time);
        this.enabled = true;
    }
    void Update()
    {//setting up a start text to begin the game that way timer does not start right away

        PlayerSettings shorter = playerSet.GetComponent<PlayerSettings>();
                
        if (startText.gameObject.activeInHierarchy == true)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startText.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
        
        timerCountDown.text = ("Time Left: " + Mathf.Round (TimeLeft));
        TimeLeft -= Time.deltaTime;

        if (TimeLeft <= 0)
        {           
            if (turnOverUI.gameObject.activeInHierarchy == false)//once time = 0 this pauses game
            {               
                //StartCoroutine(GamePaused(1.2f));
                //transition.SetTrigger("End_Round");
                turnOverUI.gameObject.SetActive(true);
                Time.timeScale = 0;    
            }
            if (Input.GetKeyDown(KeyCode.Space))//this starts next round and restarts the time
            {
                turnOverUI.gameObject.SetActive(false);
                if (firstRun == true)
                {
                    startTime = shorter.getTimerFirst();
                    firstRun = false;
                }
                else { startTime = shorter.getTimer(); }
                //keeping this debug here cause quantim mechanics seems to make it work...
                Debug.Log(playerSet.GetComponent<PlayerSettings>().getTeam());
                if (playerSet.GetComponent<PlayerSettings>().getTeam() == 1) shorter.setTeam(2);
                else shorter.setTeam(1);
                camSwap.GetComponent<CamSwap>().SwapPlayerCam();
                Time.timeScale = 1;
                //transition.SetTrigger("New_Round");
                //StartCoroutine(GamePaused(.3f));
                TimeLeft = startTime;
                // switches timer bar back forth between player turns

                if (player2UI.activeInHierarchy == true)
                {
                    player2UI.SetActive(false);
                    player1UI.SetActive(true);
                }
                else
                if (player1UI.activeInHierarchy == true)
                {
                    player1UI.SetActive(false);
                    player2UI.SetActive(true);
                }
            }
        }           
        //this sets the timer bars to match the time count down
        timeBarP1.maxValue = startTime;
        timeBarP1.value = TimeLeft;
        timeBarP2.maxValue = startTime;
        timeBarP2.value = TimeLeft;
    } 
}