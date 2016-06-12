using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {
	
	public int 		X;
	public int 		Y;
	public Sprite 	normal;
	public Sprite 	extend;
	// Use this for initialization
	void Start () {
	
	}

	IEnumerator ExtendBumper(){
		this.GetComponent<SpriteRenderer> ().sprite = extend;
		yield return new WaitForSeconds (0.3f);
		this.GetComponent<SpriteRenderer> ().sprite = normal;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			BumperManager.instance.PlayBump ();
			col.gameObject.GetComponent<Sonic>().bumper(X, Y);
			GetComponent<SpriteRenderer> ().sprite = extend;
			StartCoroutine(ExtendBumper());
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
