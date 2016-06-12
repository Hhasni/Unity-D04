using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<Sonic>().getHit();
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -13)
			Destroy (gameObject);
	
	}
}
