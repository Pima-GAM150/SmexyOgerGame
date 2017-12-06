using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyJoyInput : MonoBehaviour {

    float leftJoystickMovementX;
    float leftJoystickMovementY;
    float leftJoystickTwoMovementX;
    float leftJoystickTwoMovementY;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        leftJoystickMovementX = Input.GetAxis("Joy1_LeftXAxis");
        leftJoystickMovementY = Input.GetAxis("Joy1_LeftYAxis");

        leftJoystickTwoMovementX = Input.GetAxis("Joy2_LeftXAxis");
        leftJoystickTwoMovementY = Input.GetAxis("Joy2_LeftYAxis");

        CheckJoyOneMovement();
        CheckJoyTwoMovement();
<<<<<<< HEAD
        CheckRotation();
=======
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054


    }

    private void CheckJoyOneMovement()
    {
        //Moves player one's character according to X axis movement on the left joystick.
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


        //Moves player one's character according to Z axis movement on the left joystick.  The Y axis of the controller controls the Z axis of the character.
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
    }

    private void CheckJoyTwoMovement()
    {
        //Moves the player character according to X axis movement on the left joystick.
        if (leftJoystickTwoMovementX < 0)
        {
            gameObject.transform.Translate(new Vector3(leftJoystickTwoMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (leftJoystickTwoMovementX > 0)
        {
            gameObject.transform.Translate(new Vector3(leftJoystickTwoMovementX, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }


        //Moves the player character according to Z axis movement on the left joystick.  The Y axis of the controller controls the Z axis of the character.
        if (leftJoystickTwoMovementY < 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, leftJoystickTwoMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (leftJoystickTwoMovementY > 0)
        {
            gameObject.transform.Translate(new Vector3(0, 0, leftJoystickTwoMovementY) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }
    }
<<<<<<< HEAD

    private void CheckRotation()
    {
        if (leftJoystickTwoMovementY < 0 && leftJoystickMovementY > 0)
        {
            gameObject.transform.Rotate(new Vector3(0, -1 * 30 * Time.deltaTime, 0));
        }
        if(leftJoystickTwoMovementY > 0 && leftJoystickMovementY < 0)
        {
            gameObject.transform.Rotate(new Vector3(0, 1 * 30 * Time.deltaTime, 0));
        }
    }
=======
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
}
