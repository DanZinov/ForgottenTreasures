using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour {

	public Achievements Achievements;
	public Gems Gems;
	public UnityEngine.UI.Text CurrentMultiplier;
	public int AwayGoldMultiplier;
	public bool achievementUnlocked = false;

	void Update(){
		CurrentMultiplier.text = "Current Multiplier: " + AwayGoldMultiplier + "%"; 
	}

	public void FivePercent(){
		if (Gems.gems >= 5) {
			Gems.gems -= 5;
			AwayGoldMultiplier += 5;
		}
	}
	public void TwentyPercent(){
		if (Gems.gems >= 15) {
			Gems.gems -= 15;
			AwayGoldMultiplier += 20;
		}
	}
	public void FiftyPercent(){
		if (Gems.gems >= 40) {
			Gems.gems -= 40;
			AwayGoldMultiplier += 60;
		}
	}
	public void OneHundredPercent(){
		if (Gems.gems >= 70) {
			Gems.gems -= 70;
			AwayGoldMultiplier += 100;
		}
	}

}
