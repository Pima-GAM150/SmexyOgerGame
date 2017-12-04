using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyPadTest : MonoBehaviour {

    public GameObject P1;
	
	// Update is called once per frame
	void Update () {
        //this line gathers the direction the player wants to go
        Vector3 dirToMove = new Vector3(-Input.GetAxis("Joy1_LeftXAxis") * .25f, 0.0f, Input.GetAxis("Joy1_LeftYAxis") * .25f);
        //Vector3 dirToMove = new Vector3(-rightJoystickMovementX, 0.0f, rightJoystickMovementY);
        //gameObject.transform.Translate(dirToMove);
        //gameObject.transform.position += dirToMove;

        //P1.transform.Rotate(0.0f, rightJoystickMovementX, 0.0f);
        //gameObject.transform.Rotate(0.0f, rightJoystickMovementX, 0.0f);

        //with that direction it account for which direction the player is facing and moves accordingly
        P1.transform.Rotate(0.0f, Input.GetAxis("Joy1_RightXAxis"), 0.0f);
        gameObject.transform.position += P1.transform.TransformDirection(dirToMove);
        

    }
}
