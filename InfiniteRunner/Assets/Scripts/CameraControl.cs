using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public float distance = 3; 
	public float height = 3;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}

	void LateUpdate () {
		if (player != null) {
			Vector3 playerpos = player.transform.position;
			Vector3 offset = -player.transform.forward*distance + player.transform.up*height;
			transform.position = playerpos + offset;
			transform.LookAt(player.transform);
		}
	}
}
