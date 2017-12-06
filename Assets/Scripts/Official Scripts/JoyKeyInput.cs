using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyKeyInput : MonoBehaviour {

    float leftJoystickMovementX;
    float leftJoystickMovementY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        leftJoystickMovementX = Input.GetAxis("Joy1_LeftXAxis");
        leftJoystickMovementY = Input.GetAxis("Joy1_LeftYAxis");

        CheckJoyMovement();
        CheckKeyMovement();
<<<<<<< HEAD
        CheckRotation();
=======
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054

    }

    private void CheckJoyMovement()
    {
        //Moves player one's character according to X axis movement on the left joystick.
        if (leftJoystickMovementX < 0)
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * -6 * Time.deltaTime);
=======
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (leftJoystickMovementX > 0)
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * -6 * Time.deltaTime);
=======
            gameObject.transform.Translate(new Vector3(leftJoystickMovementX, 0, 0) * 6 * Time.deltaTime);
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
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

    private void CheckKeyMovement()
    {

        //Standard Keyboard Input
        if (Input.GetKey(KeyCode.W))
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(0, 0, -1) * 6 * Time.deltaTime);
=======
            gameObject.transform.Translate(new Vector3(1, 0, 0) * 6 * Time.deltaTime);
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.S))
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(0, 0, 1) * 6 * Time.deltaTime);
=======
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * 6 * Time.deltaTime);
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.D))
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(1, 0, 0) * 6 * Time.deltaTime);
=======
            gameObject.transform.Translate(new Vector3(0, 0, 1) * 6 * Time.deltaTime);
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.A))
        {
<<<<<<< HEAD
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }
    }

    private void CheckRotation()
    {
        if (leftJoystickMovementY > 0 && Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Rotate(new Vector3(0, -1 * 30 * Time.deltaTime, 0));
        }
        if (leftJoystickMovementY < 0 && Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Rotate(new Vector3(0, 1 * 30 * Time.deltaTime, 0));
        }
    }
=======
            gameObject.transform.Translate(new Vector3(0, 0, -1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }
    }
>>>>>>> 33bc46d16fc1abfe6b428063a8a950701da4a054
}
