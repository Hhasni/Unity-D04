using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GUIScoreScript : MonoBehaviour {

	private bool		isCalculated;
	public 	GUITimer 	TimerScript;
	private int			my_score;
	private Sonic		Player;
	private Text[] 		tPts;

	// Use this for initialization
	void Start () {
		tPts = GetComponentsInChildren<Text> ();
		Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Sonic> ();
	}

	IEnumerator BackDataSelect(){
		yield return new WaitForSeconds(10);
		Application.LoadLevel(1);
	}

	void UpdateUser(){
		PlayerPrefs.SetInt ("Rings", Player.rings);
		PlayerPrefs.SetInt ("Death", Player.deaths);
		if (PlayerPrefs.GetInt (Application.loadedLevelName + "Bscore") < my_score) {
			PlayerPrefs.SetInt (Application.loadedLevelName + "Bscore", my_score);
			PlayerPrefs.SetFloat (Application.loadedLevelName + "Btime", TimerScript.Timer);
		}
		if (PlayerPrefs.GetInt("lvl") < (Application.loadedLevel - 1))
			PlayerPrefs.SetInt ("lvl", (Application.loadedLevel - 1));
	}
	
	void Save(){
		PlayerPrefs.Save ();
	}

	// Update is called once per frame
	void Update () {
		if (!TimerScript.getime && !isCalculated) {
			isCalculated = true;
			my_score = 20000 - (Mathf.RoundToInt(TimerScript.Timer * 100));
			if (my_score < 0)
				my_score = 0;
			my_score += (100 * Player.rings);
			my_score += (500 * Player.kills);
			foreach(Text pts in tPts){
				pts.text = my_score.ToString();
			}
			UpdateUser();
			Save();
			StartCoroutine(BackDataSelect());
		}
	//	if (isCalculated)
	}
}
