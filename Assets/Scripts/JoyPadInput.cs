using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyPadInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float leftJoystickMovementX = Input.GetAxis("Joy1_LeftXAxis");
        float leftJoystickMovementY = Input.GetAxis("Joy1_LeftYAxis");
        float rightJoystickMovementX = Input.GetAxis("Joy1_RightXAxis");
        float rightJoystickMovementY = Input.GetAxis("Joy1_RightYAxis");




        //Moves the player character according to X axis movement on the left joystick.
        if (leftJoystickMovementX < 0)
        {
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (leftJoystickMovementX > 0)
        {
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }


        //Moves the player character according to Z axis movement on the left joystick.  The Y axis of the controller controls the Z axis of the character.
        if (leftJoystickMovementY < 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, leftJoystickMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (leftJoystickMovementY > 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, leftJoystickMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }


        //For the right joystick (placeholder for controller 2's left joystick for ease of testing)


        //Moves the player character according to X axis movement on the right joystick.
        if (rightJoystickMovementX < 0)
        {
            gameObject.transform.Translate(new Vector3(rightJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (rightJoystickMovementX > 0)
        {
            gameObject.transform.Translate(new Vector3(rightJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        //Moves the player character according to Z axis movement on the right joystick.  The Y axis of the controller controls the Z axis of the character.
        if (rightJoystickMovementY < 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, rightJoystickMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (rightJoystickMovementY > 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, rightJoystickMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }


    }
}
