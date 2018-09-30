using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour {

	public UnityEngine.UI.Text HowManyGems;
	public UnityEngine.UI.Text ConfirmationText;
	public GameObject ConfirmationPanel;
	public Click click;
	public GameObject SettingPanel;
	public Gems gems;


	void Update(){
		HowManyGems.text = "Reset game progress to recieve " + GoldCalculation() + " Gems";
	}
	public int GoldCalculation(){
		int gemsAmount = 0;
		if (click.gold >= 1000000f) {
			gemsAmount += 1;
		}
		if (click.gold >= 1000000000f) {
			gemsAmount += 10;
		}
		if (click.gold >= 1000000000000f) {
			gemsAmount += 20;
		}
		if (click.gold >= 1000000000000000f) {
			gemsAmount += 30;
		}
		if (click.gold >= 1000000000000000000f) {
			gemsAmount += 40;
		}
		if (click.gold >= 1000000000000000000000f) {
			gemsAmount += 60;
		}
		if (click.gold >= 1000000000000000000000000f) {
			gemsAmount += 80;
		}		
		if (click.gold >= 1000000000000000000000000000f) {
			gemsAmount += 100;
		}
		return gemsAmount;
	}

	public void Confirmation(){
		SettingPanel.gameObject.SetActive (false);
		ConfirmationPanel.gameObject.SetActive (true);
		ConfirmationText.text = "Are you sure you want to reset the game for " + GoldCalculation() + " Gems?";
	}

	public void Cancel(){
		ConfirmationPanel.gameObject.SetActive (false);
	}
	public void ResetGame(){
		File.Delete (Application.persistentDataPath + "/playerInfoAncientGrove.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeAncientGrove.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoStoneQuarry.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeStoneQuarry.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoBronzeMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeBronzeMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoSaltField.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeSaltField.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoIronMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeIronMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoSilverMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeSilverMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoGoldMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeGoldMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoEmeraldMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeEmeraldMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoDiamondMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeDiamondMine.dat");
		File.Delete (Application.persistentDataPath + "/playerInfoRubyMine.dat");
		File.Delete (Application.persistentDataPath + "/ResearchTimeRubyMine.dat");

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream gold = File.Create (Application.persistentDataPath + "/Gold.dat");
		Gold goldData = new Gold();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfoAncientGrove.dat");
		PlayerDataAncientGrove data = new PlayerDataAncientGrove ();
		data.tutorialCount = 1;
		goldData.gold = 0f;
		goldData.gems = gems.gems + GoldCalculation();
		goldData.Map2 = false;
		goldData.Map3 = false;
		goldData.Map4 = false;
		goldData.Map5 = false;
		goldData.Map6 = false;
		goldData.Map7 = false;
		goldData.Map8 = false;
		goldData.Map9 = false;
		goldData.Map10 = false;
		bf.Serialize (gold, goldData);
		bf.Serialize (file, data);
		file.Close ();
		gold.Close ();

		AsyncOperation operation = SceneManager.LoadSceneAsync (1);
	}
	
}
