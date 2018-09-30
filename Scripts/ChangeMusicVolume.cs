using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour {

	public GameObject SettingsPanel;
	public Slider Buttonclick;
	public Slider Background;
	public AudioSource ButtonclickMusic;
	public AudioSource BackgoundMusic;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SettingsPanel.gameObject.SetActive (true);
		}
		ButtonclickMusic.volume = Buttonclick.value;
		BackgoundMusic.volume = Background.value;
	}

	public void QuitApplication(){
		Application.Quit ();
	}
}
