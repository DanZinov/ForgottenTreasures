using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour {
	public ItemManager gps;
	public Click click;
	public UpgradeManager upgrade;
	public UpgradeManager upgrade1;
	public UpgradeManager upgrade2;
	public UpgradeManager upgrade3;
	public UpgradeManager upgrade4;
	public UpgradeManager upgrade5;
	public UpgradeManager upgrade6;
	public UpgradeManager upgrade7;
	public UpgradeManager upgrade8;
	public UpgradeManager upgrade9;
	public ItemManager item;
	public ItemManager item1;
	public ItemManager item2;
	public ItemManager item3;
	public ItemManager item4;
	public ItemManager item5;
	public ItemManager item6;
	public ItemManager item7;
	public ItemManager item8;
	public ItemManager item9;

	public UnityEngine.UI.Text multiplier;
	public float multiplierCounter = 1;
	public float counter = 0;

	public void MultiplierCounter(){
		multiplierCounter++;
		if((multiplierCounter/3).ToString("F2") == (counter + ".33")){
			multiplier.text = "x1";
			upgrade.multiplierUpgrade = 1;
			upgrade1.multiplierUpgrade = 1;
			upgrade2.multiplierUpgrade = 1;
			upgrade3.multiplierUpgrade = 1;
			upgrade4.multiplierUpgrade = 1;
			upgrade5.multiplierUpgrade = 1;
			upgrade6.multiplierUpgrade = 1;
			upgrade7.multiplierUpgrade = 1;
			upgrade8.multiplierUpgrade = 1;
			upgrade9.multiplierUpgrade = 1;
			item.multiplierItem = 1;
			item1.multiplierItem = 1;
			item2.multiplierItem = 1;
			item3.multiplierItem = 1;
			item4.multiplierItem = 1;
			item5.multiplierItem = 1;
			item6.multiplierItem = 1;
			item7.multiplierItem = 1;
			item8.multiplierItem = 1;
			item9.multiplierItem = 1;
		}
		else if((multiplierCounter/3).ToString("F2") == (counter + ".67")){
			multiplier.text = "x10";
			counter++;
			upgrade.multiplierUpgrade = 10;
			upgrade1.multiplierUpgrade = 10;
			upgrade2.multiplierUpgrade = 10;
			upgrade3.multiplierUpgrade = 10;
			upgrade4.multiplierUpgrade = 10;
			upgrade5.multiplierUpgrade = 10;
			upgrade6.multiplierUpgrade = 10;
			upgrade7.multiplierUpgrade = 10;
			upgrade8.multiplierUpgrade = 10;
			upgrade9.multiplierUpgrade = 10;
			item.multiplierItem = 10;
			item1.multiplierItem = 10;
			item2.multiplierItem = 10;
			item3.multiplierItem = 10;
			item4.multiplierItem = 10;
			item5.multiplierItem = 10;
			item6.multiplierItem = 10;
			item7.multiplierItem = 10;
			item8.multiplierItem = 10;
			item9.multiplierItem = 10;
		}
		else if((multiplierCounter/3).ToString("F2") == (counter + ".00")){
			multiplier.text = "x100";
			upgrade.multiplierUpgrade = 100;
			upgrade1.multiplierUpgrade = 100;
			upgrade2.multiplierUpgrade = 100;
			upgrade3.multiplierUpgrade = 100;
			upgrade4.multiplierUpgrade = 100;
			upgrade5.multiplierUpgrade = 100;
			upgrade6.multiplierUpgrade = 100;
			upgrade7.multiplierUpgrade = 100;
			upgrade8.multiplierUpgrade = 100;
			upgrade9.multiplierUpgrade = 100;
			item.multiplierItem = 100;
			item1.multiplierItem = 100;
			item2.multiplierItem = 100;
			item3.multiplierItem = 100;
			item4.multiplierItem = 100;
			item5.multiplierItem = 100;
			item6.multiplierItem = 100;
			item7.multiplierItem = 100;
			item8.multiplierItem = 100;
			item9.multiplierItem = 100;
		}

	}
}
