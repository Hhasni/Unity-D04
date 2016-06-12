using UnityEngine;
using System.Collections;

public class RampBoost : MonoBehaviour {

	public bool end;
	public int boost;
	public int direction;
	
	void Start() {
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<Sonic> ().rampBoost (direction, boost, end);
//			Debug.Log(col.gameObject.GetComponent<Sonic> ().);
//			if (end && col.gameObject.GetComponent<Sonic> ().RampCount > 3)
//				col.gameObject.GetComponent<Sonic> ().throughWall();
		}
	}

	void OnTriggerExit2d(Collider2D col){
//		if (col.gameObject.tag == "Player" && end)
	}
	
}
