using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

	public delegate void OnTriggerExitEvent();
	public static event OnTriggerExitEvent playerExited;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			if(playerExited != null)
				playerExited();
			Destroy(this.gameObject);
		}
	}
}
