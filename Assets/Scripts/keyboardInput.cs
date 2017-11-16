using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(new Vector3(1, 0, 0) * 6 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * 6 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector3(0, 0, 1) * 6 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(0, 0, -1) * 6 * Time.deltaTime);
        }

	}
}
