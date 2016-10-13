using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.transform.position = paddle.transform.position + paddleToBallVector;

		if(Input.GetMouseButtonDown(0)) {
			print("Mouse clicked, launching ball");

			this.rigidbody2D.velocity = new Vector2(2f,10f);
		}
	}
}
