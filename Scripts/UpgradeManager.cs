using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public Gems Gems;
	public Achievements Achievements;
	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public float count;
	public float clickPower;
	public string itemName;
	public Color standard;
	public Color affordable;
	public float multiplierUpgrade;
	public bool achievementUnlocked1 = false;
	public bool achievementUnlocked100 = false;
	private Slider _slider;

	void Start(){
		_slider = GetComponentInChildren<Slider> ();
	}

	void Update(){
		itemInfo.text = itemName + " (" + count + ")" + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString((cost * multiplierUpgrade), false) + "\nPower: +" + CurrencyConverter.Instance.GetCurrencyIntoString((clickPower * multiplierUpgrade), false);

		_slider.value = click.gold / (cost * multiplierUpgrade) * 100;

		if (_slider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	public void PurchasedUpgrade(){
		if (click.gold >= cost * multiplierUpgrade) {
			click.gold -= cost * multiplierUpgrade;
			count += 1 * multiplierUpgrade;
			click.goldPerClick += clickPower * multiplierUpgrade;
			cost = Mathf.Round(cost * multiplierUpgrade * 1.15f);
		}
	}
}
