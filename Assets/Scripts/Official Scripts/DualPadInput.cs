using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPadInput : MonoBehaviour {

    float leftJoystickMovementX;
    float leftJoystickMovementY;
    float rightJoystickMovementX;
    float rightJoystickMovementY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        leftJoystickMovementX = Input.GetAxis("Joy1_LeftXAxis");
        leftJoystickMovementY = Input.GetAxis("Joy1_LeftYAxis");
        rightJoystickMovementX = Input.GetAxis("Joy1_RightXAxis");
        rightJoystickMovementY = Input.GetAxis("Joy1_RightYAxis");

        CheckLeftStickMovement();
        CheckRightStickMovement();
        CheckRotation();


        leftJoystickMovementX = Input.GetAxis("Joy1_LeftXAxis");
        leftJoystickMovementY = Input.GetAxis("Joy1_LeftYAxis");
        rightJoystickMovementX = Input.GetAxis("Joy1_RightXAxis");
        rightJoystickMovementY = Input.GetAxis("Joy1_RightYAxis");

        CheckLeftStickMovement();
        CheckRightStickMovement();


    }

    private void CheckLeftStickMovement()
    {
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
    }

    private void CheckRightStickMovement()
    {
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

    private void CheckRotation()
    {
        if (rightJoystickMovementY < 0 && leftJoystickMovementY > 0)
        {
            gameObject.transform.Rotate(new Vector3 (0, -1 * 30 * Time.deltaTime, 0));
        }

        if (leftJoystickMovementY < 0 && rightJoystickMovementY > 0)
        {
            gameObject.transform.Rotate(new Vector3(0, 1 * 30 * Time.deltaTime, 0));
        }

    }
}
