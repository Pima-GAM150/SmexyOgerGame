using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontBehavior : MonoBehaviour {

    public Transform playerPos;
    Vector3 scale = new Vector3(0.001f,0.001f,0.001f);
	// Update is called once per frame
	void Update () {
        transform.GetChild(0).transform.localScale += scale;
        transform.GetChild(0).transform.LookAt(-playerPos.position);
        if (transform.GetChild(0).transform.localScale.x > 1.1)
            scale *= -1;
        if (transform.GetChild(0).transform.localScale.x < .9)
            scale *= -1;
	}

    public void EnableDisable(bool input) {
        transform.GetChild(0).gameObject.SetActive(input);
    }
}
