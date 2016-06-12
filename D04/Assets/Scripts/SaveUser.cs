using UnityEngine;
using System.Collections;

public class SaveUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("rings", 255);
//		if (PlayerPrefs.GetString ("user") != null) {
//			input.text = PlayerPrefs.GetString ("lives");
//		}
	
	}
	
	// Update is called once per frame
	public void UpdateUser () {
//		PlayerPrefs.SetString ("live");
	}

	public void Save(){
//		PlayerPrefs.Save ();
	}
}
