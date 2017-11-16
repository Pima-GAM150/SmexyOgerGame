using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontBehavior : MonoBehaviour {

    Vector3 scale = new Vector3(0.001f,0.001f,0.001f);
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().localScale += scale;
        if (GetComponent<Transform>().localScale.x > 1.1)
            scale *= -1;
        if (GetComponent<Transform>().localScale.x < .9)
            scale *= -1;

	}

    void Start () {
        gameObject.SetActive(false);
    }

    void EnableDisable(bool input) {
        gameObject.SetActive(input);
    }
}
