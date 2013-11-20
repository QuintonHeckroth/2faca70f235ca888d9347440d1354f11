using UnityEngine;
using System.Collections;

// sup g

public class Lantern : MonoBehaviour {
	// Use this for initialization
	GameObject player;
	//
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			dropLantern();
		}
	}
	void OnCollisionEnter2D (Collision2D col) {
		switch(col.collider.tag){
			case "Player" :
				this.transform.parent = player.transform;
				this.transform.localPosition = new Vector3(2f, 0f, -1f);
				Destroy(rigidbody2D);
				break;
		}
	}
	void dropLantern(){
		this.transform.parent = null;
		this.gameObject.AddComponent<Rigidbody2D>();
		this.rigidbody2D.AddForce(new Vector2(200f, 200f));
	}
}
