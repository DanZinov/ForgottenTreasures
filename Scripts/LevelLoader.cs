using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class LevelLoader : MonoBehaviour {

	public GameObject LoadingPanel;
	public Slider MySlider;
	public UnityEngine.UI.Text LoadingProgress;
	[SerializeField]
	private int GroveSceneIndex;

	void Start(){
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build ();
		PlayGamesPlatform.InitializeInstance (config);
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {
			if(Social.localUser.authenticated == true){
				StartCoroutine (LoadAsynchronously (GroveSceneIndex));
			} else {
				LoadingProgress.text = "No Internet Connection";
			}
		});
	}
		
	IEnumerator LoadAsynchronously(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		LoadingPanel.SetActive (true);
		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / 0.9f);
			LoadingProgress.text = "Loading: " + Mathf.RoundToInt(progress * 100) + "%";
			MySlider.value = progress;
			yield return null;
		}
	}

}
