using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlinkingScript : MonoBehaviour {

	Text 		my_text;
	string 		bkp_text;
	bool 		flag;
	void Start () {
		flag = true;
		my_text = GetComponent<Text> ();
		bkp_text = my_text.text;
		StartCoroutine(BlinkText());
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Return))
			Application.LoadLevel (1);
	}
	// Update is called once per frame

	public IEnumerator BlinkText(){
		while (flag) {
			my_text.text = "";
			yield return new WaitForSeconds(.5f);
			my_text.text = bkp_text;
			yield return new WaitForSeconds(.5f);
		}
	}
}
