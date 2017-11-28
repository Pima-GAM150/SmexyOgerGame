using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerController : MonoBehaviour {

    //Variables for the selection of the player's input.
    private keyboardInput keyboardInput;
    private JoyKeyInput joyKeyInput;
    private DualPadInput dualPadInput;
    private JoyJoyInput joyJoyInput;
    public static string playerInputMode;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

        joyKeyInput = GetComponent<JoyKeyInput>();
        keyboardInput = GetComponent<keyboardInput>();
        dualPadInput = GetComponent<DualPadInput>();
        joyJoyInput = GetComponent<JoyJoyInput>();


        //Switch statement for the selection of player input.
        switch (playerInputMode)
        {
            case "JoyPad & Keyboard":
                keyboardInput.enabled = false;
                joyKeyInput.enabled = true;
                dualPadInput.enabled = false;
                joyJoyInput.enabled = false;
                break;

            case "JoyPad & JoyPad2":
                joyKeyInput.enabled = false;
                keyboardInput.enabled = false;
                dualPadInput.enabled = false;
                joyJoyInput.enabled = true;
                break;

            case "DualPad":
                dualPadInput.enabled = true;
                joyKeyInput.enabled = false;
                joyJoyInput.enabled = false;
                keyboardInput.enabled = false;
                print("You have selected the dualpad input method");
                break;

            case "Keyboard":
                dualPadInput.enabled = false;
                joyKeyInput.enabled = false;
                joyJoyInput.enabled = false;
                keyboardInput.enabled = true;
                break;
        }
    }

}
