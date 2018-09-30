using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;
using UnityEngine.UI;

public class PlayAd : MonoBehaviour {

	public GameObject AdButton;
	public Gems Gems;

	public void ShowButton(){
		if (Advertisement.IsReady () && AdButton.gameObject.activeSelf == false) {
			AdButton.gameObject.SetActive (true);
			this.gameObject.GetComponent<Animator> ().Play ("Ad", -1, 0.0f);
		}
	}
	public void ShowAd(){
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("rewardedVideo", new ShowOptions(){resultCallback = HandleAdResult});
		}
	}
	private void HandleAdResult (ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			AdButton.gameObject.SetActive (false);
			Gems.gems += 2;
			break;
		case ShowResult.Skipped:
			break;
		case ShowResult.Failed:
			break;
		}
	}
}
