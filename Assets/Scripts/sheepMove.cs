using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepMove : MonoBehaviour {

    public float moveSpeed;

    private Rigidbody myRigidbody;

    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody>();

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMove * 1.25f);

	}
	
	// Update is called once per frame
	void Update () {

        if (moving) {

            timeToMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = moveDirection;

            if(timeToMoveCounter < 0f) {
                moving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
            }
        }

        else {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector3.zero;

            if (timeBetweenMoveCounter < 0f) {
                moving = true;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, 0f, Random.Range(-1, 1f) * moveSpeed);
            }
        }
	}
}
