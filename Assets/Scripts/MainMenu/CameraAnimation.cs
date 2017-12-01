using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour {

	public Animator settingsAnimator;
	public Animator creditsAnimator;
	public Animator playAnimator;

	public void ClickOnSettings(){
	
		settingsAnimator.SetTrigger ("SettingsClick");
	}

	public void ClickOnCredits(){

		creditsAnimator.SetTrigger ("CreditsClick");
	}

	public void ClickOnPlay(){

		playAnimator.SetTrigger ("PlayClick");
	}
}
