using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;

	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Lock the ball relative to the paddle.
			this.transform.transform.position = paddle.transform.position + paddleToBallVector;

			// Wait for a mouse press to launch.
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, launching ball");
				hasStarted = true;
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 10f);
			}
		}
	}
}
