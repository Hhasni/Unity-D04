using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelecteScript : MonoBehaviour {

	public Text 	StageName;
	public Text 	StageTime;
	public Text 	StageScore;
	public string 	my_name;
	private string 	StartName;
	private string 	StartTime;
	private string 	StartScore;
	public Image[] imgs;
	// Use this for initialization
	void Start () {
		StartName = StageName.text;
		StartTime = StageTime.text;
		StartScore = StageScore.text;
		imgs = GetComponentsInChildren<Image> ();
	}

	void OnMouseOver(){
		StageName.text = my_name;
		if (PlayerPrefs.GetInt (my_name + "Bscore") > 0) {
			StageScore.text = PlayerPrefs.GetInt (my_name + "Bscore").ToString ();
			float tmp = PlayerPrefs.GetFloat (my_name + "Btime");
			StageTime.text = Mathf.Floor (tmp / 59).ToString ("00") + ": " + (tmp % 59).ToString ("00");
		} else {
			StageScore.text = StartScore;
			StageTime.text = StartTime;
		}
	}

	void OnMouseExit(){
		StageName.text = "";
		StageScore.text = "";
		StageTime.text = "";
	}

	void OnMouseDown() {
		if (imgs [1].IsActive () == false)
			Application.LoadLevel (my_name);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
