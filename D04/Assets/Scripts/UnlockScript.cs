using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnlockScript : MonoBehaviour {


	public StageSelecteScript[] tab;
	// Use this for initialization
	void Start () {
		tab = GetComponentsInChildren<StageSelecteScript> ();
		for (int i = 0; i < PlayerPrefs.GetInt("lvl"); i++){
			Image[] tmp = tab[i].GetComponentsInChildren<Image>();
			if (tmp[1].enabled == true)
				tmp[1].enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
