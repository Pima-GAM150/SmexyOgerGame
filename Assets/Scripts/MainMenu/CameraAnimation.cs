using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour {

	public Animator animator;

	public void ClickOnSettings(){
	
		animator.SetTrigger ("SettingsClick");
	}

	public void ClickOnCredits(){

		print ("ClickedOnCredits");
	}

	public void ClickOnPlay(){

		print ("ClickedOnPlay");
	}
}
