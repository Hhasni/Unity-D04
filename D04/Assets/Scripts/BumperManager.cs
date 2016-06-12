using UnityEngine;
using System.Collections;

public class BumperManager : MonoBehaviour {

	public static BumperManager 	instance { get; private set; }
	private AudioSource				my_audio;
	// Use this for initialization
	void Start () {
		
	}
	
	void Awake(){
		instance = this;
		my_audio = GetComponent<AudioSource> ();
	}
	
	public void PlayBump(){
		my_audio.Play ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
