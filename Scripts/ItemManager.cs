using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

	public GPS gps;
	public Gems Gems;
	public Achievements Achievements;
	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public float tickValue;
	public float count;
	public Color standard;
	public Color affordable;
	public string itemName;
	public float multiplierItem;
	public bool achievementUnlocked1 = false;
	public bool achievementUnlocked100 = false;
	private Slider _slider;

	void Start(){
		_slider = GetComponentInChildren<Slider> ();
	}

	void Update(){
		itemInfo.text = itemName + " (" + count + ")" + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString((cost * multiplierItem), false) + "\nWood: " + CurrencyConverter.Instance.GetCurrencyIntoString((tickValue * multiplierItem), false)+ "/s";
		_slider.value = click.gold / (cost * multiplierItem) * 100;

		if (_slider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	public void PurchasedItem(){
		if (click.gold >= cost * multiplierItem) {
			click.gold -= cost * multiplierItem;
			count += 1 * multiplierItem;
			tickValue = tickValue * multiplierItem;
			cost = Mathf.Round (cost * multiplierItem * 1.15f);
			gps.goldPerSecond += tickValue;
		}
	}
}
