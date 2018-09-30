using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchManager : MonoBehaviour {

	public GameObject Finish1;
	public GameObject Finish2;
	public GameObject Finish3;
	public GameObject Finish4;
	public GameObject Finish5;
	public GameObject Finish6;
	public GameObject Finish7;
	public GameObject Finish8;
	public GameObject Finish9;
	public GameObject Finish10;
	public Gems Gems;
	public Achievements Achievements;
	public UpgradeManager[] Upgrades;
	public GameObject Max;
	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public string itemName;
	public int time;
	public Color standard;
	public Color affordable;
	public Color clicked;
	private Slider _slider;
	public GPS GPS;
	public int count = 0;
	public float startTime;
	public bool done = false;
	public bool achievementUnlocked = false;
	public float timeNow;

	void Start(){
		_slider = GetComponentInChildren<Slider> ();
		Max.gameObject.SetActive (false);
	}
		
	void Update(){
		timeNow = (System.DateTime.Now.Second + (System.DateTime.Now.Minute * 60) + (System.DateTime.Now.Hour * 60 * 60));
		if (count == 0 && done == false) {
			itemInfo.text = "\n" + itemName + "\n" + "Time: " + time + " Minutes" + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString ((cost), false);
			_slider.value = click.gold / (cost) * 100;

			if (_slider.value >= 100) {
				GetComponent<Image> ().color = affordable;
			} else {
				GetComponent<Image> ().color = standard;
			}
		}
		if(count == 1 && done == false){
			itemInfo.text = "\n" + "Time Left: " + (time - (Mathf.RoundToInt((timeNow - startTime)/60))) + " Minutes";
			GetComponent<Image> ().color = standard;
		}
		if(count == 1 && done == true){
			itemInfo.text = "\n" + "Research Completed";
		}
		if(done == true){
			itemInfo.text = "\n" + "Research Completed";
		}
	}

	public void Research1(){
		if (click.gold >= cost && count == 0) {
			Finish1.gameObject.SetActive (true);
			click.gold -= cost;
			count += 1;
			startTime = timeNow;
			Gems.gems += 5;
			//GetComponent<Image> ().color = clicked;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research2(){
		if (click.gold >= cost && count == 0) {
			Finish2.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			count += 1;
			//GetComponent<Image> ().color = clicked;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research3(){
		if (click.gold >= cost && count == 0) {
			Finish3.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			count += 1;
			//GetComponent<Image> ().color = clicked;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research4(){
		if (click.gold >= cost && count == 0) {
			Finish4.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			count += 1;
			//GetComponent<Image> ().color = clicked;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research5(){
		if (click.gold >= cost && count == 0) {
			Finish5.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			count += 1;
			//GetComponent<Image> ().color = clicked;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research6(){
		if (click.gold >= cost && count == 0) {
			Finish6.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			//GetComponent<Image> ().color = clicked;
			count += 1;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research7(){
		if (click.gold >= cost && count == 0) {
			Finish7.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			//GetComponent<Image> ().color = clicked;
			count += 1;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research8(){
		if (click.gold >= cost && count == 0) {
			Finish8.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			//GetComponent<Image> ().color = clicked;
			count += 1;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research9(){
		if (click.gold >= cost && count == 0) {
			Finish9.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			//GetComponent<Image> ().color = clicked;
			count += 1;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	public void Research10(){
		if (click.gold >= cost && count == 0) {
			Finish10.gameObject.SetActive (true);
			click.gold -= cost;
			startTime = timeNow;
			//GetComponent<Image> ().color = clicked;
			count += 1;
		}
		else if(count >= 1){
			StartCoroutine (WaitSeconds());
		}
	}
	IEnumerator WaitSeconds(){
		Max.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		Max.gameObject.SetActive (false);
	}
}
