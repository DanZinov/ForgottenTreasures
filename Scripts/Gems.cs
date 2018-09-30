using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Gems : MonoBehaviour {

	public Achievements Achievements;
	public int gems;
	public GameObject GemsPanel;
	public UnityEngine.UI.Text GemsText;


	void Update(){
		GemsText.text = gems.ToString();
	}
		
}
