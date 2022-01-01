using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TGBackMainMenu : MonoBehaviour {
	public string MainScene = "VROutdoorCinemaMenuGearVR";

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene(MainScene);			
		}	
	}
}
