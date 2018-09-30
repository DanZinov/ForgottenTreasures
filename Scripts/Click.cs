using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text GPC;
	public UnityEngine.UI.Text goldDisplay;
	public float gold = 0f;
	public float goldPerClick = 1;
	
	// Update is called once per frame
	void Update () {
		goldDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(gold, true);
		GPC.text = "GPC : " + CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false);
	}

	public void Clicked(){
		gold += goldPerClick;
	}
}
