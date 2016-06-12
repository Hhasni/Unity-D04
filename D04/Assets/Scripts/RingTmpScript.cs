using UnityEngine;
using System.Collections;

public class RingTmpScript : MonoBehaviour {
		// Use this for initialization
	void Start () {
		Invoke ("Pickable", 2);
	}

	void Pickable(){
		gameObject.layer = 0;
		StartCoroutine (blink ());
	}
	
	public IEnumerator blink(){
		yield return new WaitForSeconds (0.1f);
		GetComponent<SpriteRenderer> ().enabled = !GetComponent<SpriteRenderer> ().enabled;
		StartCoroutine (blink ());
		yield return new WaitForSeconds (4f);
		StopAllCoroutines ();
		Destroy (gameObject);
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			RingManager.instance.PlayRing();
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
