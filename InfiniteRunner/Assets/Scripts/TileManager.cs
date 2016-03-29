using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

	public GameObject prefab;
	public GameObject current;
	
	void OnEnable(){
		TileScript.playerExited += spawnOne;
	}

	void OnDisenable(){
		TileScript.playerExited -= spawnOne;
	}

	protected void spawnOne(){
		current = (GameObject) Instantiate (prefab, current.transform.GetChild ((int)Random.Range(0,2)).position, Quaternion.identity);
	}


	// Use this for initialization
	void Start () {
		SpawnTile ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnTile(){
		for(int i  = 0; i < 10; i++)
			current = (GameObject) Instantiate (prefab, current.transform.GetChild ((int)Random.Range(0,2)).position, Quaternion.identity);
	}
}
