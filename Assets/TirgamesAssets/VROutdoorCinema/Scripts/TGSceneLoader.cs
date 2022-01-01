using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TGSceneLoader : MonoBehaviour {

	public void LoadScene(string SceneName) {
		SceneManager.LoadScene(SceneName);
	}
}
