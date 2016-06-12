using UnityEngine;
using System.Collections;

public class TVScirpt : MonoBehaviour {

	public GameObject	gShield;
	public AudioSource	mainSong;
	public Sprite 		sBorkenTV;
	public string 		type;
	private Collider2D	my_collider;
	private Animator	my_animator;
	private SpriteRenderer		my_sprite;
	// Use this for initialization
	void Start () {
		my_collider = GetComponent<Collider2D> ();
		my_animator = GetComponent<Animator> ();
		my_sprite = GetComponent<SpriteRenderer> ();
	}

	IEnumerator PowerSneakers(Sonic player){
		yield return new WaitForSeconds (15f);
		player.maxSpeed = 20;
		mainSong.pitch = 1f;
	}

	void checkBonus (Sonic player){
		switch (type) {
		case "Rings":
			Debug.Log("RINGS");
			player.rings += 10;
			break;
		case "Sneakers":
			player.maxSpeed = 30;
			mainSong.pitch = 1.2f;
			StartCoroutine(PowerSneakers(player));
			break;
		case "Shield":
			player.currentShield = Instantiate(gShield, player.transform.position, player.transform.rotation) as GameObject;
			player.currentShield.transform.SetParent(player.transform);
			player.currentShield.transform.localScale = new Vector3(1,1,1);
			player.currentShield.transform.localPosition = new Vector3(0,-0.2f,0);
			player.isShielded = true;
			break;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Sonic tmp = col.gameObject.GetComponent<Sonic>();
			if (tmp.isJumpball || tmp.isRolling){
				tmp.destroy();
				my_collider.enabled = false;
				my_animator.enabled = false;
				my_sprite.sprite = sBorkenTV;
				checkBonus(tmp);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
