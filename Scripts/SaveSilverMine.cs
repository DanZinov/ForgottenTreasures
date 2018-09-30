using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class SaveSilverMine : MonoBehaviour {

	public GameObject CostButton2;
	public GameObject CostButton3;
	public GameObject CostButton4;
	public GameObject CostButton5;
	public GameObject CostButton6;
	public GameObject CostButton7;
	public GameObject CostButton8;
	public GameObject CostButton9;
	public GameObject CostButton10;
	private float Map2Cost = 10000000f;
	private float Map3Cost = 10000000000f;
	private float Map4Cost = 10000000000000f;
	private float Map5Cost = 10000000000000000f;
	private float Map6Cost = 10000000000000000000f;
	private float Map7Cost = 10000000000000000000000f;
	private float Map8Cost = 10000000000000000000000000f;
	private float Map9Cost = 1000000000000000000000000000f;
	private float Map10Cost = 900000000000000000000000000000f;
	public bool Map2 = false;
	public bool Map3 = false;
	public bool Map4 = false;
	public bool Map5 = false;
	public bool Map6 = false;
	public bool Map7 = false;
	public bool Map8 = false;
	public bool Map9 = false;
	public bool Map10 = false;
	public GameObject AwayGold;
	public GameObject Continue;
	public Gems Gems;
	public Bank Bank;
	public ResearchManager[] Researches;
	public ItemManager[] Items;
	public UpgradeManager[] Upgrades;
	public Click click;
	public GPS GPS;
	public float Seconds;
	public float Minutes;
	public float Hours;
	public float Day;
	public float Total;
	public float differenceSeconds;
	public float differenceDays;
	public UnityEngine.UI.Text awayGold;

	void Start(){
		if (File.Exists (Application.persistentDataPath + "/Gold.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
			Gold goldData = (Gold)bf.Deserialize (goldf);
			goldf.Close ();
			Map2 = goldData.Map2;
			Map3 = goldData.Map3;
			Map4 = goldData.Map4;
			Map5 = goldData.Map5;
			Map6 = goldData.Map6;
			Map7 = goldData.Map7;
			Map8 = goldData.Map8;
			Map9 = goldData.Map9;
			Map10 = goldData.Map10;
			Debug.Log (goldData.gold);
			click.gold = goldData.gold;
			Gems.gems = goldData.gems;
		}
		if (File.Exists (Application.persistentDataPath + "/playerInfoSilverMine.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream playerInfo = File.Open (Application.persistentDataPath + "/playerInfoSilverMine.dat", FileMode.Open);
			PlayerDataSilverMine playerInfoData = (PlayerDataSilverMine)bf.Deserialize (playerInfo);
			playerInfo.Close ();
			Seconds = System.DateTime.Now.Second;
			Minutes = System.DateTime.Now.Minute;
			Hours = System.DateTime.Now.Hour;
			Day = System.DateTime.Now.DayOfYear;
			Total = Seconds + Minutes * 60 + Hours * 60 * 60;
			differenceSeconds = Total - playerInfoData.Total;

			for (int i = 0; i < 10; i++) {
				Items [i].count = playerInfoData.itemsArrayCount [i];
			}

			for (int i = 0; i < 10; i++) {
				Items [i].cost = playerInfoData.itemsArrayCost [i];
			}

			for (int i = 0; i < 10; i++) {
				Upgrades [i].count = playerInfoData.upgradesArrayCount [i];
			}

			for (int i = 0; i < 10; i++) {
				Upgrades [i].cost = playerInfoData.upgradesArrayCost [i];
			}

			Bank.AwayGoldMultiplier = playerInfoData.AwayGoldMultiplier;

			click.goldPerClick = playerInfoData.goldPerClick;
			GPS.goldPerSecond = playerInfoData.goldPerSecond;

			if (playerInfoData.Day < Day) {
				differenceDays = Day - playerInfoData.Day;
				click.gold = click.gold + ((playerInfoData.goldPerSecond * ((24 - playerInfoData.Hours + Hours) * 60 * 60) * differenceDays) + ((playerInfoData.goldPerSecond * ((24 - playerInfoData.Hours + Hours) * 60 * 60) * differenceDays) * (Bank.AwayGoldMultiplier)/100));
				awayGold.text = CurrencyConverter.Instance.GetCurrencyIntoString (((playerInfoData.goldPerSecond * ((24 - playerInfoData.Hours + Hours) * 60 * 60) * differenceDays) + ((playerInfoData.goldPerSecond * ((24 - playerInfoData.Hours + Hours) * 60 * 60) * differenceDays) * (Bank.AwayGoldMultiplier)/100)), true) + " gold";
			} else {
				click.gold = (click.gold + (playerInfoData.goldPerSecond * differenceSeconds) + ((playerInfoData.goldPerSecond * differenceSeconds) * (Bank.AwayGoldMultiplier)/100));
				awayGold.text = CurrencyConverter.Instance.GetCurrencyIntoString (((playerInfoData.goldPerSecond * differenceSeconds) + ((playerInfoData.goldPerSecond * differenceSeconds) * (Bank.AwayGoldMultiplier)/100)), true) + " gold";
			}

		}
		if (click.gold == 0) {
			AwayGold.gameObject.SetActive (false);
			Continue.gameObject.SetActive (false);
		} else {
			AwayGold.gameObject.SetActive (true);
			Continue.gameObject.SetActive (true);
		}
		if (File.Exists (Application.persistentDataPath + "/ResearchTimeSilverMine.dat")){
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream researchTime = File.Open (Application.persistentDataPath + "/ResearchTimeSilverMine.dat", FileMode.Open);
			PlayerDataSilverMine researchTimeData = (PlayerDataSilverMine)bf.Deserialize (researchTime);
			researchTime.Close ();

			Debug.Log ("Researches [0].count" + Researches [0].count);
			Debug.Log ("Researches [1].count" + Researches [1].count);
			Researches [0].count = researchTimeData.researchCount0;
			Researches [1].count = researchTimeData.researchCount1;
			Researches [2].count = researchTimeData.researchCount2;
			Researches [3].count = researchTimeData.researchCount3;
			Researches [4].count = researchTimeData.researchCount4;
			Researches [5].count = researchTimeData.researchCount5;
			Researches [6].count = researchTimeData.researchCount6;
			Researches [7].count = researchTimeData.researchCount7;
			Researches [8].count = researchTimeData.researchCount8;
			Researches [9].count = researchTimeData.researchCount9;
			Debug.Log ("Researches [0].startTime" + Researches [0].startTime);
			Debug.Log ("Researches [1].startTime" + Researches [1].startTime);
			Researches [0].startTime = researchTimeData.researchTime0;
			Researches [1].startTime = researchTimeData.researchTime1;
			Researches [2].startTime = researchTimeData.researchTime2;
			Researches [3].startTime = researchTimeData.researchTime3;
			Researches [4].startTime = researchTimeData.researchTime4;
			Researches [5].startTime = researchTimeData.researchTime5;
			Researches [6].startTime = researchTimeData.researchTime6;
			Researches [7].startTime = researchTimeData.researchTime7;
			Researches [8].startTime = researchTimeData.researchTime8;
			Researches [9].startTime = researchTimeData.researchTime9;
			if(researchTimeData.researchTime0 > 0){
				if (Total - researchTimeData.researchTime0 >= 600 && Researches [0].done == false) {
					GPS.goldPerSecond = GPS.goldPerSecond * 2;
					Researches [0].done = true;
				}
			}
			if(researchTimeData.researchTime1 > 0){
				if (Total - researchTimeData.researchTime1 >= 900 && Researches [1].done == false) {
					click.goldPerClick = click.goldPerClick * 2;
					Researches [1].done = true;
				}
			} 
			if(researchTimeData.researchTime2 > 0){
				if (Total - researchTimeData.researchTime2 >= 900 && Researches [2].done == false) {
					click.goldPerClick = click.goldPerClick * 3;
					Researches [2].done = true;
				}
			} 
			if(researchTimeData.researchTime3 > 0){
				if (Total - researchTimeData.researchTime3 >= 1200 && Researches [3].done == false) {
					GPS.goldPerSecond = GPS.goldPerSecond * 2;
					click.goldPerClick = click.goldPerClick * 2;
					Researches [3].done = true;
				}
			} 
			if(researchTimeData.researchTime4 > 0){
				if (Total - researchTimeData.researchTime4 >= 3600 && Researches [4].done == false) {
					GPS.goldPerSecond = GPS.goldPerSecond * 10;
					Researches [4].done = true;
				}
			} 
			if(researchTimeData.researchTime5 > 0){
				if (Total - researchTimeData.researchTime5 >= 9000 && Researches [5].done == false) {
					Upgrades [0].cost = Upgrades [0].cost - (Upgrades [0].cost * 0.1f);
					Upgrades [1].cost = Upgrades [1].cost - (Upgrades [1].cost * 0.1f);
					Upgrades [2].cost = Upgrades [2].cost - (Upgrades [2].cost * 0.1f);
					Upgrades [3].cost = Upgrades [3].cost - (Upgrades [3].cost * 0.1f);
					Upgrades [4].cost = Upgrades [4].cost - (Upgrades [4].cost * 0.1f);
					Upgrades [5].cost = Upgrades [5].cost - (Upgrades [5].cost * 0.1f);
					Upgrades [6].cost = Upgrades [6].cost - (Upgrades [6].cost * 0.1f);
					Upgrades [7].cost = Upgrades [7].cost - (Upgrades [7].cost * 0.1f);
					Upgrades [8].cost = Upgrades [8].cost - (Upgrades [8].cost * 0.1f);
					Upgrades [9].cost = Upgrades [9].cost - (Upgrades [9].cost * 0.1f);
					Researches [5].done = true;
				}
			} 
			if(researchTimeData.researchTime6 > 0){
				if (Total - researchTimeData.researchTime6 >= 18000 && Researches [6].done == false) {
					GPS.goldPerSecond = GPS.goldPerSecond * 4;
					click.goldPerClick = click.goldPerClick * 4;
					Researches [6].done = true;
				}
			} 
			if(researchTimeData.researchTime7 > 0){
				if (Total - researchTimeData.researchTime7 >= 21000 && Researches [7].done == false) {
					click.goldPerClick = click.goldPerClick * 50;
					Researches [7].done = true;
				}
			} 
			if(researchTimeData.researchTime8 > 0){
				if (Total - researchTimeData.researchTime8 >= 30000 && Researches [8].done == false) {
					Upgrades [0].cost = Upgrades [0].cost - (Upgrades [0].cost * 0.5f);
					Upgrades [1].cost = Upgrades [1].cost - (Upgrades [1].cost * 0.5f);
					Upgrades [2].cost = Upgrades [2].cost - (Upgrades [2].cost * 0.5f);
					Upgrades [3].cost = Upgrades [3].cost - (Upgrades [3].cost * 0.5f);
					Upgrades [4].cost = Upgrades [4].cost - (Upgrades [4].cost * 0.5f);
					Upgrades [5].cost = Upgrades [5].cost - (Upgrades [5].cost * 0.5f);
					Upgrades [6].cost = Upgrades [6].cost - (Upgrades [6].cost * 0.5f);
					Upgrades [7].cost = Upgrades [7].cost - (Upgrades [7].cost * 0.5f);
					Upgrades [8].cost = Upgrades [8].cost - (Upgrades [8].cost * 0.5f);
					Upgrades [9].cost = Upgrades [9].cost - (Upgrades [9].cost * 0.5f);
					Researches [8].done = true;
				}
			} 
			if(researchTimeData.researchTime9 > 0){
				if (Total - researchTimeData.researchTime9 >= 36000 && Researches [9].done == false) {
					GPS.goldPerSecond = GPS.goldPerSecond * 4;
					Researches [9].done = true;
				}
			}
		}
	}
	public void PurchaseMap2(){
		if (click.gold >= Map2Cost && Map2 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map2Cost;
			Map2 = true;
			CostButton2.gameObject.SetActive (false);
			goldData.Map2 = true;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap3(){
		if (click.gold >= Map3Cost && Map3 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map3Cost;
			Map3 = true;
			CostButton3.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = true;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap4(){
		if (click.gold >= Map4Cost && Map4 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map4Cost;
			Map4 = true;
			CostButton4.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = true;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap5(){
		if (click.gold >= Map5Cost && Map5 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map5Cost;
			Map5 = true;
			CostButton5.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = true;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;

		}
	}
	public void PurchaseMap6(){
		if (click.gold >= Map6Cost && Map6 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map6Cost;
			Map6 = true;
			CostButton6.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = true;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap7(){
		if (click.gold >= Map7Cost && Map7 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map7Cost;
			Map7 = true;
			CostButton7.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = true;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap8(){
		if (click.gold >= Map8Cost && Map8 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map8Cost;
			Map8 = true;
			CostButton8.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = true;
			goldData.Map9 = Map9;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap9(){
		if (click.gold >= Map9Cost && Map9 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map9Cost;
			Map9 = true;
			CostButton9.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = true;
			goldData.Map10 = Map10;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	public void PurchaseMap10(){
		if (click.gold >= Map10Cost && Map10 == false) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
			Gold goldData = new Gold();
			click.gold -= Map10Cost;
			Map10 = true;
			CostButton10.gameObject.SetActive (false);
			goldData.Map2 = Map2;
			goldData.Map3 = Map3;
			goldData.Map4 = Map4;
			goldData.Map5 = Map5;
			goldData.Map6 = Map6;
			goldData.Map7 = Map7;
			goldData.Map8 = Map8;
			goldData.Map9 = Map9;
			goldData.Map10 = true;
			goldData.gems = Gems.gems;
			goldData.gold = click.gold;
			bf.Serialize (gold, goldData);
			gold.Close ();
		}
	}
	void OnApplicationPause(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfoSilverMine.dat");
		PlayerDataSilverMine data = new PlayerDataSilverMine ();
		FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
		Gold goldData = new Gold();

		data.Seconds = System.DateTime.Now.Second;
		data.Minutes = System.DateTime.Now.Minute;
		data.Hours = System.DateTime.Now.Hour;
		data.Day = System.DateTime.Now.DayOfYear;
		data.Total = data.Seconds + data.Minutes * 60 + data.Hours * 60 * 60;

		data.goldPerSecond = GPS.goldPerSecond;
		goldData.Map2 = Map2;
		goldData.Map3 = Map3;
		goldData.Map4 = Map4;
		goldData.Map5 = Map5;
		goldData.Map6 = Map6;
		goldData.Map7 = Map7;
		goldData.Map8 = Map8;
		goldData.Map9 = Map9;
		goldData.Map10 = Map10;
		goldData.gold = click.gold;

		data.goldPerClick = click.goldPerClick;

		for (int i = 0; i < 10; i++) {
			data.itemsArrayCount [i] = Items [i].count;
		}

		for (int i = 0; i < 10; i++) {
			data.itemsArrayCost [i] = Items [i].cost;
		}

		for (int i = 0; i < 10; i++) {
			data.upgradesArrayCount [i] = Upgrades [i].count;
		}

		for (int i = 0; i < 10; i++) {
			data.upgradesArrayCost [i] = Upgrades [i].cost;
		}

		goldData.gems = Gems.gems;
		data.AwayGoldMultiplier = Bank.AwayGoldMultiplier;


		bf.Serialize (file, data);
		bf.Serialize (gold, goldData);
		file.Close ();
		gold.Close ();
	}
	public void ChangedScene(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfoSilverMine.dat");
		PlayerDataSilverMine data = new PlayerDataSilverMine ();
		FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
		Gold goldData = new Gold();

		data.Seconds = System.DateTime.Now.Second;
		data.Minutes = System.DateTime.Now.Minute;
		data.Hours = System.DateTime.Now.Hour;
		data.Day = System.DateTime.Now.DayOfYear;
		data.Total = data.Seconds + data.Minutes * 60 + data.Hours * 60 * 60;

		data.goldPerSecond = GPS.goldPerSecond;

		Debug.Log ("Saved" + click.gold + "Gold");
		goldData.gold = click.gold;
		goldData.Map2 = Map2;
		goldData.Map3 = Map3;
		goldData.Map4 = Map4;
		goldData.Map5 = Map5;
		goldData.Map6 = Map6;
		goldData.Map7 = Map7;
		goldData.Map8 = Map8;
		goldData.Map9 = Map9;
		goldData.Map10 = Map10;
		data.goldPerClick = click.goldPerClick;

		for (int i = 0; i < 10; i++) {
			data.itemsArrayCount [i] = Items [i].count;
		}

		for (int i = 0; i < 10; i++) {
			data.itemsArrayCost [i] = Items [i].cost;
		}

		for (int i = 0; i < 10; i++) {
			data.upgradesArrayCount [i] = Upgrades [i].count;
		}

		for (int i = 0; i < 10; i++) {
			data.upgradesArrayCost [i] = Upgrades [i].cost;
		}

		goldData.gems = Gems.gems;
		data.AwayGoldMultiplier = Bank.AwayGoldMultiplier;


		bf.Serialize (file, data);
		bf.Serialize (gold, goldData);
		file.Close ();
		gold.Close ();
	}
	public void WhenClicked(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/ResearchTimeSilverMine.dat");
		PlayerDataSilverMine data = new PlayerDataSilverMine ();
		Debug.Log ("data.researchCount0" + data.researchCount0);
		data.researchCount0 = Researches [0].count;
		data.researchCount1 = Researches [1].count;
		data.researchCount2 = Researches [2].count;
		data.researchCount3 = Researches [3].count;
		data.researchCount4 = Researches [4].count;
		data.researchCount5 = Researches [5].count;
		data.researchCount6 = Researches [6].count;
		data.researchCount7 = Researches [7].count;
		data.researchCount8 = Researches [8].count;
		data.researchCount9 = Researches [9].count;

		Debug.Log ("data.researchTime0 " + data.researchTime0);
		Debug.Log ("Researches [0].startTime" + Researches [0].startTime);
		if (Researches [0].startTime > 0) {
			data.researchTime0 = Researches [0].startTime;
		} if (Researches [1].startTime > 0) {
			data.researchTime1 = Researches [1].startTime;
		} if (Researches [2].startTime > 0) {
			data.researchTime2 = Researches [2].startTime;
		} if (Researches [3].startTime > 0) {
			data.researchTime3 = Researches [3].startTime;
		} if (Researches [4].startTime > 0) {
			data.researchTime4 = Researches [4].startTime;
		} if (Researches [5].startTime > 0) {
			data.researchTime5 = Researches [5].startTime;
		} if (Researches [6].startTime > 0) {
			data.researchTime6 = Researches [6].startTime;
		} if (Researches [7].startTime > 0) {
			data.researchTime7 = Researches [7].startTime;
		} if (Researches [8].startTime > 0) {
			data.researchTime8 = Researches [8].startTime;
		} if (Researches [9].startTime > 0) {
			data.researchTime9 = Researches [9].startTime;
		}
		bf.Serialize (file, data);
		file.Close ();
	}

}
[Serializable]
class PlayerDataSilverMine{

	public float[] itemsArrayCount = {0,0,0,0,0,0,0,0,0,0};

	public float[] itemsArrayCost = {0,0,0,0,0,0,0,0,0,0};

	public float[] upgradesArrayCount = {0,0,0,0,0,0,0,0,0,0};

	public float[] upgradesArrayCost = {0,0,0,0,0,0,0,0,0,0};

	public float researchTime0;
	public float researchTime1;
	public float researchTime2;
	public float researchTime3;
	public float researchTime4;
	public float researchTime5;
	public float researchTime6;
	public float researchTime7;
	public float researchTime8;
	public float researchTime9;

	public int researchCount0;
	public int researchCount1;
	public int researchCount2;
	public int researchCount3;
	public int researchCount4;
	public int researchCount5;
	public int researchCount6;
	public int researchCount7;
	public int researchCount8;
	public int researchCount9;

	public float goldPerClick = 1;

	public float Seconds;
	public float Minutes;
	public float Hours;
	public float Day;
	public float Total;

	public float goldPerSecond;

	public int AwayGoldMultiplier;
}
