using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIRing : MonoBehaviour {
	
	private Text ring;
	private Sonic playerScript;
	// Use this for initialization
	void Start () {
		ring = GetComponentInChildren<Text> ();
		playerScript = GameObject.FindWithTag ("Player").GetComponent<Sonic>();
	}
	
	// Update is called once per frame
	void Update () {
		ring.text = playerScript.rings.ToString ();
	
	}
}
