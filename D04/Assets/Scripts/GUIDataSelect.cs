using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIDataSelect : MonoBehaviour {
	
	public Text 		tRings; 
	public Text 		tDeaths; 
	// Use this for initialization
	void Start () {
		tRings.text = PlayerPrefs.GetInt ("Rings").ToString ();
		tDeaths.text = PlayerPrefs.GetInt ("Deaths").ToString ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
