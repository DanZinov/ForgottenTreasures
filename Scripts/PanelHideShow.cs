using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class PanelHideShow : MonoBehaviour {

	public GameObject ReviewPanel;
	public GameObject DailyRewards;
	public GameObject CostButton2;
	public GameObject CostButton3;
	public GameObject CostButton4;
	public GameObject CostButton5;
	public GameObject CostButton6;
	public GameObject CostButton7;
	public GameObject CostButton8;
	public GameObject CostButton9;
	public GameObject CostButton10;
	public GameObject DiamondMine;
	public GameObject RubyMine;
	public GameObject EmeraldMine;
	public GameObject GoldMine;
	public GameObject SilverMine;
	public GameObject IronMine;
	public GameObject BronzeMine;
	public GameObject SaltMine;
	public GameObject StoneQuarry;
	public GameObject AncientGrove;
	public GameObject FirstUpgradePanel;
	public GameObject FirstItemPanel;
	public GameObject HundredUpgradesPanel;
	public GameObject HundredItemsPanel;
	public GameObject BankUpgradePanel;
	public GameObject WorldPurchasePanel;
	public GameObject FirstResearchPanel;
	public GameObject StorePanel;
	public GameObject SettingsButton;
	public GameObject UpgradesInfoButton;
	public GameObject ItemsInfoButton;
	public GameObject ResearchesInfoButton;
	public GameObject MapInfoButton;
	public GameObject BankInfoPanel;
	public GameObject UpgradesInfoPanel;
	public GameObject ItemsInfoPanel;
	public GameObject ResearchesInfoPanel;
	public GameObject MapInfoPanel;
	public GameObject BankPanel;
	public GameObject Multiplier;
	public GameObject MapPanel;
	public GameObject Continue;
	public GameObject AwayGold;
	public GameObject SettingsPanel;
	public GameObject UpgradePanel;
	public GameObject ItemsPanel;
	public GameObject ResearchPanel;

	void Start(){
		ResearchPanel.gameObject.SetActive (false);
		UpgradePanel.gameObject.SetActive (false);
		ItemsPanel.gameObject.SetActive (false);
		SettingsPanel.gameObject.SetActive (false);
		MapPanel.gameObject.SetActive (false);
		BankPanel.gameObject.SetActive (false);
		UpgradesInfoButton.gameObject.SetActive (false);
		ItemsInfoButton.gameObject.SetActive (false);
		ResearchesInfoButton.gameObject.SetActive (false);
		MapInfoButton.gameObject.SetActive (false);
		BankInfoPanel.gameObject.SetActive (false);
		StorePanel.gameObject.SetActive (false);

	}


	public void UpgradePanelShowHide(){
		if (UpgradePanel.gameObject.activeSelf) {
			UpgradePanel.gameObject.SetActive (false);
			UpgradesInfoButton.gameObject.SetActive (false);
			ItemsInfoButton.gameObject.SetActive (false);
			ResearchesInfoButton.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (true);
		} else if (UpgradePanel.gameObject.activeSelf == false) {
			UpgradePanel.gameObject.SetActive (true);
			UpgradesInfoButton.gameObject.SetActive (true);
			ResearchPanel.gameObject.SetActive (false);
			SettingsPanel.gameObject.SetActive (false);
			ItemsPanel.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (false);
		}
	}

	public void ItemsPanelShowHide(){
		if (ItemsPanel.gameObject.activeSelf) {
			ItemsPanel.gameObject.SetActive (false);
			ItemsInfoButton.gameObject.SetActive (false);
			ResearchesInfoButton.gameObject.SetActive (false);
			UpgradesInfoButton.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (true);
		} else if (ItemsPanel.gameObject.activeSelf == false) {
			ItemsPanel.gameObject.SetActive (true);
			ItemsInfoButton.gameObject.SetActive (true);
			ResearchPanel.gameObject.SetActive (false);
			SettingsPanel.gameObject.SetActive (false);
			UpgradePanel.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (false);
		}
	}
	public void SettingsPanelShowHide(){
		if (SettingsPanel.gameObject.activeSelf) {
			SettingsPanel.gameObject.SetActive (false);
		} else if(SettingsPanel.gameObject.activeSelf == false){
			SettingsPanel.gameObject.SetActive (true);
			UpgradePanel.gameObject.SetActive (false);
			ItemsPanel.gameObject.SetActive (false);
			ResearchPanel.gameObject.SetActive (false);
			BankPanel.gameObject.SetActive (false);
			StorePanel.gameObject.SetActive (false);
		}
	}
	public void ResearchPanelShowHide(){
		if (ResearchPanel.gameObject.activeSelf) {
			ResearchPanel.gameObject.SetActive (false);
			ResearchesInfoButton.gameObject.SetActive (false);
			UpgradesInfoButton.gameObject.SetActive (false);
			ItemsInfoButton.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (true);
		} else if(ResearchPanel.gameObject.activeSelf == false){
			ResearchPanel.gameObject.SetActive (true);
			ResearchesInfoButton.gameObject.SetActive (true);
			SettingsPanel.gameObject.SetActive (false);
			UpgradePanel.gameObject.SetActive (false);
			ItemsPanel.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (false);
		}
	}
	public void MapPanelShowHide(){
		if (MapPanel.gameObject.activeSelf) {
			CostButton2.gameObject.SetActive (false);
			CostButton3.gameObject.SetActive (false);
			CostButton4.gameObject.SetActive (false);
			CostButton5.gameObject.SetActive (false);
			CostButton6.gameObject.SetActive (false);
			CostButton7.gameObject.SetActive (false);
			CostButton8.gameObject.SetActive (false);
			CostButton9.gameObject.SetActive (false);
			CostButton10.gameObject.SetActive (false);
			MapPanel.gameObject.SetActive (false);
			Multiplier.gameObject.SetActive (true);
			MapInfoButton.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (true);
			AncientGrove.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
		} else if(MapPanel.gameObject.activeSelf == false){
			MapPanel.gameObject.SetActive (true);
			MapInfoButton.gameObject.SetActive (true);
			ResearchesInfoButton.gameObject.SetActive (false);
			ItemsInfoButton.gameObject.SetActive (false);
			UpgradesInfoButton.gameObject.SetActive (false);
			ResearchPanel.gameObject.SetActive (false);
			SettingsPanel.gameObject.SetActive (false);
			UpgradePanel.gameObject.SetActive (false);
			ItemsPanel.gameObject.SetActive (false);
			Multiplier.gameObject.SetActive (false);
			SettingsButton.gameObject.SetActive (false);
		}
	}
	public void AwayGoldPanelShowHide(){
		if (Continue.gameObject.activeSelf) {
			Continue.gameObject.SetActive (false);
		}
	}
	public void BankPanelShowHide(){
		if (BankPanel.gameObject.activeSelf == false) {
			BankPanel.gameObject.SetActive (true);
			SettingsPanel.gameObject.SetActive (false);
			StorePanel.gameObject.SetActive (false);
		} else {
			BankPanel.gameObject.SetActive (false);
		}
	}
	public void StorePanelShowHide(){
		if (StorePanel.gameObject.activeSelf == false) {
			StorePanel.gameObject.SetActive (true);
			SettingsPanel.gameObject.SetActive (false);
			BankPanel.gameObject.SetActive (false);
		} else {
			StorePanel.gameObject.SetActive (false);
		}
	}

	public void BankInfo(){
		if (BankInfoPanel.gameObject.activeSelf == false) {
			BankInfoPanel.gameObject.SetActive (true);
		} else {
			BankInfoPanel.gameObject.SetActive (false);
		}
			
	}
	public void UpgradesInfo(){
		if (UpgradesInfoPanel.gameObject.activeSelf == false) {
			UpgradesInfoPanel.gameObject.SetActive (true);
		} else {
			UpgradesInfoPanel.gameObject.SetActive (false);
		}

	}
	public void ItemsInfo(){
		if (ItemsInfoPanel.gameObject.activeSelf == false) {
			ItemsInfoPanel.gameObject.SetActive (true);
		} else {
			ItemsInfoPanel.gameObject.SetActive (false);
		}

	}
	public void ResearchesInfo(){
		if (ResearchesInfoPanel.gameObject.activeSelf == false) {
			ResearchesInfoPanel.gameObject.SetActive (true);
		} else {
			ResearchesInfoPanel.gameObject.SetActive (false);
		}

	}
	public void MapInfo(){
		if (MapInfoPanel.gameObject.activeSelf == false) {
			MapInfoPanel.gameObject.SetActive (true);
		} else {
			MapInfoPanel.gameObject.SetActive (false);
		}

	}

	public void AchievementFirstUpgradeHide(){
		FirstUpgradePanel.gameObject.SetActive (false);
	}
	public void AchievementFirstItemHide(){
		FirstItemPanel.gameObject.SetActive (false);
	}
	public void AchievementFirstResearchHide(){
		FirstResearchPanel.gameObject.SetActive (false);
	}
	public void AchievementHundredUpgradesHide(){
		HundredUpgradesPanel.gameObject.SetActive (false);
	}
	public void AchievementHundredItemsHide(){
		HundredItemsPanel.gameObject.SetActive (false);
	}
	public void AchievementBankUpgradeHide(){
		BankUpgradePanel.gameObject.SetActive (false);
	}
	public void AchievementWorldPurchaseHide(){
		WorldPurchasePanel.gameObject.SetActive (false);
	}
	public void AncientGroveButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (AncientGrove.gameObject.activeSelf == false) {
			AncientGrove.gameObject.SetActive (true);
			StoneQuarry.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		} else {
			AncientGrove.gameObject.SetActive (false);
		}
	}

	public void StoneQuarryButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		Debug.Log (goldData.Map2);
		Debug.Log (CostButton2.gameObject.activeSelf);
		if (StoneQuarry.gameObject.activeSelf == false && goldData.Map2 == true) {
			CostButton2.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (true);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton2.gameObject.activeSelf == false && goldData.Map2 == false) {
			CostButton2.gameObject.SetActive (true);
		}
		else {
			CostButton2.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
		}
	}
	public void SaltMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (SaltMine.gameObject.activeSelf == false && goldData.Map3 == true) {
			CostButton3.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (true);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton3.gameObject.activeSelf == false && goldData.Map3 == false) {
			CostButton3.gameObject.SetActive (true);
		}
		else {
			CostButton3.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
		}
	}
	public void BronzeMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (BronzeMine.gameObject.activeSelf == false && goldData.Map4 == true) {
			CostButton4.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (true);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		} 
		else if (CostButton4.gameObject.activeSelf == false && goldData.Map4 == false) {
			CostButton4.gameObject.SetActive (true);
		}
		else {
			CostButton4.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
		}
	}
	public void IronMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (IronMine.gameObject.activeSelf == false && goldData.Map5 == true) {
			CostButton5.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (true);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton5.gameObject.activeSelf == false && goldData.Map5 == false) {
			CostButton5.gameObject.SetActive (true);
		}
		else {
			CostButton5.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
		}
	}
	public void SilverMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (SilverMine.gameObject.activeSelf == false && goldData.Map6 == true) {
			CostButton6.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (true);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton6.gameObject.activeSelf == false && goldData.Map6 == false) {
			CostButton6.gameObject.SetActive (true);
		}
		else {
			CostButton6.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
		}
	}
	public void GoldMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (GoldMine.gameObject.activeSelf == false && goldData.Map7 == true) {
			CostButton7.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (true);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton7.gameObject.activeSelf == false && goldData.Map7 == false) {
			CostButton7.gameObject.SetActive (true);
		}
		else {
			CostButton7.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
		}
	}
	public void EmeraldMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (EmeraldMine.gameObject.activeSelf == false && goldData.Map8 == true) {
			CostButton8.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (true);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton8.gameObject.activeSelf == false && goldData.Map8 == false) {
			CostButton8.gameObject.SetActive (true);
		}
		else {
			CostButton8.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
		}
	}
	public void RubyMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (RubyMine.gameObject.activeSelf == false && goldData.Map9 == true) {
			CostButton9.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (true);
			DiamondMine.gameObject.SetActive (false);
		}
		else if (CostButton9.gameObject.activeSelf == false && goldData.Map9 == false) {
			CostButton9.gameObject.SetActive (true);
		}
		else {
			CostButton9.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
		}
	}
	public void DiamondMineButton(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream goldf = File.Open (Application.persistentDataPath + "/Gold.dat", FileMode.Open);
		Gold goldData = (Gold)bf.Deserialize (goldf);
		goldf.Close ();
		if (DiamondMine.gameObject.activeSelf == false && goldData.Map10 == true) {
			CostButton10.gameObject.SetActive (false);
			StoneQuarry.gameObject.SetActive (false);
			AncientGrove.gameObject.SetActive (false);
			SaltMine.gameObject.SetActive (false);
			BronzeMine.gameObject.SetActive (false);
			IronMine.gameObject.SetActive (false);
			SilverMine.gameObject.SetActive (false);
			GoldMine.gameObject.SetActive (false);
			EmeraldMine.gameObject.SetActive (false);
			RubyMine.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (true);
		}
		else if (CostButton10.gameObject.activeSelf == false && goldData.Map10 == false) {
			CostButton10.gameObject.SetActive (true);
		}
		else {
			CostButton10.gameObject.SetActive (false);
			DiamondMine.gameObject.SetActive (false);
		}
	}
	public void HideDailyRewards(){
		if (DailyRewards.gameObject.activeSelf) {
			DailyRewards.gameObject.SetActive (false);
		}
	}

	public void CloseReview(){
		if (ReviewPanel.gameObject.activeSelf) {
			ReviewPanel.gameObject.SetActive (false);
		}
	}
	public void OpenGoogle(){
		Application.OpenURL ("https://play.google.com/store/apps/details?id=com.firelandvalley.forgottentreasures");
		ReviewPanel.gameObject.SetActive (false);
	}
}
