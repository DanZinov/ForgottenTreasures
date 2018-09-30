using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour {
	public Gems gems;
	public UnityEngine.UI.Text fastForward;
	public UnityEngine.UI.Text gpsDisplay;
	public Click click;
	public float goldPerSecond;
	// Use this for initialization
	void Start () {
		StartCoroutine (AutoTick ());
	}

	// Update is called once per frame
	void Update () {
		gpsDisplay.text = "GPS : " + CurrencyConverter.Instance.GetCurrencyIntoString(goldPerSecond, false);
		fastForward.text = "Fast Forward" + " 2 Hours" + "\n" + CurrencyConverter.Instance.GetCurrencyIntoString((goldPerSecond * 7200), true) + " Gold"; 
	}
	public void AutoGoldPerSec(){
		click.gold += goldPerSecond / 10;
	}

	IEnumerator AutoTick(){
		while (true) {
			AutoGoldPerSec ();
			yield return new WaitForSeconds (0.10f);
		}
	}

	public void FastForward(){
		if (gems.gems >= 40) {
			click.gold += (goldPerSecond * 7200);
			gems.gems -= 40;
		}
	}
}
