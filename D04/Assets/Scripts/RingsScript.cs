using UnityEngine;
using System.Collections;

public class RingsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			RingManager.instance.PlayRing();
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
