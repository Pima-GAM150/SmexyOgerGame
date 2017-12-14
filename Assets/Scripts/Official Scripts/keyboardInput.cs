using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        CheckWASDMovement();
        CheckArrowMovement();
        CheckRotation();

    }

    private void CheckWASDMovement()
    {
        //Standard Keyboard Input
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(new Vector3(0, 0, 1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(new Vector3(0, 0, -1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector3(1, 0, 1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }
    }

    private void CheckArrowMovement()
    {
        //Arrow Key Keyboard Input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, 1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector3(0, 0, -1) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(1, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * 6 * Time.deltaTime);
            //animator.SetBool("isMoving", true);  <- This will be used for the state machine later, so I'll just leave it here.
        }
    }

    private void CheckRotation()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(new Vector3(0, 1 * 30 * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(new Vector3(0, -1 * 30 * Time.deltaTime, 0));
        }
    }
}
