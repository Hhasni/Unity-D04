using UnityEngine;
using System.Collections;

public class SpikeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Player"){
			if (col.contacts[0].normal != Vector2.right && col.contacts[0].normal != -Vector2.right)
				col.gameObject.GetComponent<Sonic>().getHit();
		}		
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player"){
			if (col.contacts[0].normal != Vector2.right && col.contacts[0].normal != -Vector2.right)
				col.gameObject.GetComponent<Sonic>().getHit();
		}
		
	}

	// Update is called once per frame
	void Update () {
	
	}
}
