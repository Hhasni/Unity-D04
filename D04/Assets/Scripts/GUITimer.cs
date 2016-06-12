using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUITimer : MonoBehaviour {
	
	private Text time;
	public float Timer;
	public bool getime;
	// Use this for initialization
	void Start () {
		getime = true;
		time = GetComponentInChildren<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (getime)
			Timer = Time.timeSinceLevelLoad;
		string minutes = Mathf.Floor(Timer / 59).ToString();
		string seconds = (Timer % 59).ToString("00");
		time.text = minutes + ": " + seconds;
	}
}
