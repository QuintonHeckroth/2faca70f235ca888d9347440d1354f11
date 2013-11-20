using UnityEngine;
using System.Collections;

public class BoyController : MonoBehaviour {

	int horizontalAxis;
	public float boyMoveForce = 10;
	public float boyJumpForce = 10;

	// Use this for initialization
	void Start ()
	{
		horizontalAxis = (int)Input.GetAxis("Horizontal");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void FixedUpdate ()
	{
		switch(horizontalAxis)
		{
		case 0:
		break;
		case -1:
			rigidbody2D.AddForce(Vector2.right * horizontalAxis * boyMoveForce);
		break;
		case 1:
			rigidbody2D.AddForce(Vector2.right * horizontalAxis * boyMoveForce);
		break;
		default:
		break;
		}
	}
}
