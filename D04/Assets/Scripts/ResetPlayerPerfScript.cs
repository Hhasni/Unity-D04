using UnityEngine;
using System.Collections;

public class ResetPlayerPerfScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	public void ResetPlayerPerf(){
		PlayerPrefs.DeleteAll ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
