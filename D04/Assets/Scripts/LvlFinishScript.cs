using UnityEngine;
using System.Collections;

public class LvlFinishScript : MonoBehaviour {
	
	private Animator		panelSpinAnimation;
	private bool			startTime;
	private float			Timer;
	private	AudioSource		my_audio;
	private	AudioSource		master_audio;
	private GUITimer 		guitimer;
	private CanvasGroup		guiscore;
	public 	GameObject		UIpanel;
	// Use this for initialization
	void Start () {
		guitimer = UIpanel.GetComponentInChildren<GUITimer> ();
		guiscore = UIpanel.transform.parent.GetComponentInChildren<CanvasGroup> ();
		startTime = false;
		panelSpinAnimation = GetComponent<Animator> ();
		my_audio = GetComponent<AudioSource> ();
		master_audio = GameObject.Find ("map").GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "Player" && !startTime ) {
			col.gameObject.GetComponent<Sonic>().finish = true;
			startTime = true;
			guitimer.getime = false;
			master_audio.Stop();
			my_audio.Play();
			Camera.main.transform.SetParent(gameObject.transform.parent);
			Camera.main.transform.localPosition = new Vector3(0,0.75f,0);
			panelSpinAnimation.SetBool ("active", true);
		}
	}

	// Update is called once per frame
	void Update () {
		if (startTime) {
		//	Debug.Log("Timer == " + Timer.ToString());
			Timer += Time.deltaTime;
			if (Timer >= 6.1f)
				guiscore.alpha = 1f;
				//Debug.Log("SCOREEE");
		}
	}
}
