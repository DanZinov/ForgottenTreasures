using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {
	public int count;
	public GameObject multiplier;
	public GameObject SettingIcon;
	public GameObject MapHelpIcon;
	public GameObject ResearchHelpIcon;
	public GameObject ItemHelpIcon;
	public GameObject UpgradeHelpIcon;
	public GameObject BankPanel;
	public GameObject UpgradePanel;
	public GameObject ItemPanel;
	public GameObject ResearchPanel;
	public GameObject MapPanel;
	public GameObject Welcome;
	public GameObject ContinueBeginning;
	public GameObject ContinueUpgrade;
	public GameObject ContinueItem;
	public GameObject ContinueResearch;
	public GameObject ContinueMap;
	public GameObject Upgrade;
	public GameObject UpgradeClicked;
	public GameObject Item;
	public GameObject ItemClicked;
	public GameObject Research;
	public GameObject ResearchClicked;
	public GameObject Map;
	public GameObject MapClicked;
	public GameObject Bank;
	public GameObject BankClicked;
	public GameObject ContinueBank;
	public GameObject Character;
	public GameObject Finish;
	public GameObject ContinueFinish;


	void Start(){
		if (count == 0) {
			Welcome.gameObject.SetActive (true);
			Character.gameObject.SetActive (true);
		}
	}


	public void HideWelcome(){
		if (count == 0) {
			Welcome.gameObject.SetActive (false);
			ContinueBeginning.gameObject.SetActive (false);
			Upgrade.gameObject.SetActive (true);
		}
	}

	public void HideUpgrade(){
		if (count == 0) {
			if (UpgradePanel.gameObject.activeSelf) {
				Upgrade.gameObject.SetActive (false);
				UpgradeClicked.gameObject.SetActive (true);
				ContinueUpgrade.gameObject.SetActive (true);
			}
		}
	}

	public void HideUpgradeClicked(){
		if (count == 0) {
			UpgradeClicked.gameObject.SetActive (false);
			ContinueUpgrade.gameObject.SetActive (false);
			Item.gameObject.SetActive (true);
		}
	}

	public void HideItem(){
		if (count == 0) {
			if (ItemPanel.gameObject.activeSelf) {
				Item.gameObject.SetActive (false);
				ItemClicked.gameObject.SetActive (true);
				ContinueItem.gameObject.SetActive (true);
			}
		}
	}

	public void HideItemClicked(){
		if (count == 0) {
			ItemClicked.gameObject.SetActive (false);
			ContinueItem.gameObject.SetActive (false);
			Research.gameObject.SetActive (true);
		}
	}

	public void HideResearch(){
		if (count == 0) {
			if (ResearchPanel.gameObject.activeSelf) {
				Research.gameObject.SetActive (false);
				ResearchClicked.gameObject.SetActive (true);
				ContinueResearch.gameObject.SetActive (true);
			}
		}
	}

	public void HideResearchClicked(){
		if (count == 0) {
			ResearchClicked.gameObject.SetActive (false);
			ContinueResearch.gameObject.SetActive (false);
			Map.gameObject.SetActive (true);
		}
	}

	public void HideMap(){
		if (count == 0) {
			if (MapPanel.gameObject.activeSelf) {
				Map.gameObject.SetActive (false);
				MapClicked.gameObject.SetActive (true);
				ContinueMap.gameObject.SetActive (true);
			}
		}
	}

	public void HideMapClicked(){
		if (count == 0) {
			MapClicked.gameObject.SetActive (false);
			ContinueMap.gameObject.SetActive (false);
			MapPanel.gameObject.SetActive (false);
			SettingIcon.gameObject.SetActive (true);
			multiplier.gameObject.SetActive (true);
			MapHelpIcon.gameObject.SetActive (false);
			ItemHelpIcon.gameObject.SetActive (false);
			ResearchHelpIcon.gameObject.SetActive (false);
			UpgradeHelpIcon.gameObject.SetActive (false);
			Bank.gameObject.SetActive (true);
		}
	}
	public void HideBank(){
		if (count == 0) {
			Bank.gameObject.SetActive (false);
			BankClicked.gameObject.SetActive (true);
			ContinueBank.gameObject.SetActive (true);
			Character.gameObject.SetActive (false);
		}
	}
	public void HideBankClicked(){
		if (count == 0) {
			BankClicked.gameObject.SetActive (false);
			ContinueBank.gameObject.SetActive (false);
			BankPanel.gameObject.SetActive (false);
			Finish.gameObject.SetActive (true);
			Character.gameObject.SetActive (true);
		}
	}

	public void HideFinish(){
		if (count == 0) {
			Finish.gameObject.SetActive (false);
			ContinueFinish.gameObject.SetActive (false);
			Character.gameObject.SetActive (false);
			count += 1;
		}
	}
}
