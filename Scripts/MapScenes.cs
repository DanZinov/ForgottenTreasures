using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MapScenes : MonoBehaviour {

	public bool achievementUnlocked = false;

	public void LoadDiamondMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (10);
	}
	public void LoadRubyMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (9);
	}
	public void LoadEmeraldMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (8);
	}
	public void LoadGoldMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (7);
	}
	public void LoadSilverMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (6);
	}
	public void LoadIronMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (5);
	}
	public void LoadBronzeMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (4);
	}
	public void LoadSaltMine(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (3);
	}
	public void LoadRockQuarry(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (2);
	}
	public void LoadAncientGrove(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (1);
	}

}
