using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingControl : MonoBehaviour {
	public GameObject loadingScreenObject;
	public Slider slider;

	AsyncOperation async;

	public void LoadScreen(int iLevel) {
		StartCoroutine(LoadingScreen(iLevel));
	}

	IEnumerator LoadingScreen(int level) {
		loadingScreenObject.SetActive(true);
		async = SceneManager.LoadSceneAsync(level);
		async.allowSceneActivation = false;
		yield return new WaitForSeconds(3);
		while(async.isDone == false) {
			slider.value = async.progress;

			if(async.progress == 0.9f) {
				slider.value = 1f;
				async.allowSceneActivation = true;
			} 
			yield return null;
		}
	}
}
