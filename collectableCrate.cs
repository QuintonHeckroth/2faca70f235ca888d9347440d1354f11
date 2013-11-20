using UnityEngine;
using System.Collections;

public class collectableCrate : MonoBehaviour {
	public float objectAlpha = 255f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col){
		this.StartCoroutine(FadeOut(2));
		//
//		Color newAlpha = new Color(255,255,255,objectAlpha);
		//
//		Destroy(this);
	}

	IEnumerator FadeOut(float aTime)
	{
		Color targetColor = this.renderer.material.color;

		for (float i = 1f; i > -1f; i-=0.1f){
			targetColor.a = i;
			this.renderer.material.color = targetColor;
			yield return new WaitForEndOfFrame();
		}

		Destroy(this);
	}

}
