using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public Vector2 		my_vector;
	public float		moveSpeed;
	public float		timer;
	public int			minX;
	public int			maxX;
	public GameObject	gShoot;
	private bool		Dangerous;
	private SpriteRenderer 		my_spriteR;
	public  Sprite		sAttack;
	private Sprite		sNormal;
	public enum Type{tower, normal, attack};
	public Type type;
	// Use this for initialization
	void Start () {
		Dangerous = false;
		my_vector = new Vector2 (-1, 0);
		my_spriteR = GetComponent<SpriteRenderer> ();
		sNormal = my_spriteR.sprite;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Sonic tmp = col.gameObject.GetComponent<Sonic>();
			if (Dangerous)
				tmp.getHit();
			else if (tmp.isJumpball || tmp.isRolling){
				tmp.kills += 1;
				tmp.destroy();
				Destroy(gameObject);
			}
			else
				tmp.getHit();

		}
	}

	void ft_check_x (){
		if (transform.position.x < minX) 
			transform.rotation = Quaternion.Euler(0,180,0);
		if (transform.position.x > maxX)
			transform.rotation = Quaternion.Euler(0,0,0);
	}

	IEnumerator AttackThenNormal(){
		yield return new WaitForSeconds (2f);
		Dangerous = false;
		my_spriteR.sprite = sNormal;
		timer = 0;
	}

	void attack(){
		Dangerous = true;
		my_spriteR.sprite = sAttack;
		StartCoroutine (AttackThenNormal ());
	}

	void shoot(){
		GameObject tmp = Instantiate (gShoot, transform.position, transform.rotation) as GameObject;
		tmp.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 8), ForceMode2D.Impulse);
	}

	// Update is called once per frame
	void Update () {
		if (type != Type.tower && !Dangerous) {
			ft_check_x ();
			transform.Translate (my_vector * moveSpeed * Time.deltaTime);
		}
		if (timer > 5) {
			timer = 0;
			if (type == Type.attack)
				attack();
			else if (type == Type.tower)
				shoot();
		}
		timer += Time.deltaTime;
	}
}
