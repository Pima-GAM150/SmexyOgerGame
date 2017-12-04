using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OgreDistance : MonoBehaviour {

    //This script is used to tell the human or any other objects that the ogre gets close to
    //to give the ogre permission to interact with them and then also make text appear over
    //the interactable object.

    public GameObject human;
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(human.transform.position,gameObject.transform.position) < 5) {
            human.GetComponentInChildren<FontBehavior>().EnableDisable(true);
            //give permission to controller to pick up human
        }
        else human.GetComponentInChildren<FontBehavior>().EnableDisable(false);
    }
}
