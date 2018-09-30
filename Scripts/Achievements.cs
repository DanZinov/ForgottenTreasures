using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Achievements : MonoBehaviour {


	public GameObject FirstUpgradePanel;
	public GameObject FirstItemPanel;
	public GameObject HundredUpgradesPanel;
	public GameObject HundredItemsPanel;
	public GameObject BankUpgradePanel;
	public GameObject FirstResearchPanel;
	public UpgradeManager UpgradeManager;
	public ItemManager ItemManager;
	public Bank Bank;
	public Gems Gems;
	public ResearchManager ResearchManager;

	public void FirstUpgrade(){
		if (UpgradeManager.achievementUnlocked1 == false) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_first_upgrade, 100, success => {
				UpgradeManager.achievementUnlocked1 = true;
				FirstUpgradePanel.gameObject.SetActive(true);
				Gems.gems += 5;
			});
		}

	}

	public void FirstItem(){
		if (ItemManager.achievementUnlocked1 == false) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_first_item, 100, success => {
				ItemManager.achievementUnlocked1 = true;
				FirstItemPanel.gameObject.SetActive(true);
				Gems.gems += 5;
			});
		}

	}
	public void FirstResearch(){
		if (ResearchManager.achievementUnlocked == false) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_first_research, 100, success => {
				ResearchManager.achievementUnlocked = true;
				FirstResearchPanel.gameObject.SetActive(true);
				Gems.gems += 5;
			});
		}

	}
	public void HundredUpgrades(){
		if (UpgradeManager.achievementUnlocked100 == false && UpgradeManager.count == 100) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_100_upgrades, 100, success => {
				UpgradeManager.achievementUnlocked100 = true;
				HundredUpgradesPanel.gameObject.SetActive(true);
				Gems.gems += 10;
			});
		}
	}
	public void HundredItems(){
		if (ItemManager.achievementUnlocked100 == false && ItemManager.count == 100) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_100_items, 100, success => {
				ItemManager.achievementUnlocked100 = true;
				HundredItemsPanel.gameObject.SetActive(true);
				Gems.gems += 10;
			});
		}
	}
	public void BankUpgrade(){
		if (Bank.achievementUnlocked == false) {
			Social.ReportProgress (ForgottenTreasuresAch.achievement_purchase_bank_upgrade, 100, success => {
				Bank.achievementUnlocked = true;
				BankUpgradePanel.gameObject.SetActive(true);
				Gems.gems += 20;
			});
		}
	}

	public void AchievementsUI(){
		Social.ShowAchievementsUI ();
	}
		
}
