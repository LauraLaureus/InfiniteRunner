using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	private Vector3 nextCorner;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		nextCorner = transform.forward;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetMouseButtonDown(0)) {
			if(nextCorner == Vector3.forward){
				nextCorner = Vector3.left;
			}
			else {
				nextCorner = Vector3.forward;
			}
		} // works also for screen

		transform.rotation = Quaternion.Lerp (
			transform.rotation,
			Quaternion.LookRotation (nextCorner, Vector3.up),
			Time.fixedDeltaTime
			);
		rb.velocity = transform.forward * speed;
	}


}
