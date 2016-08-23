using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelLoad : MonoBehaviour {

	public GameObject platform ;

	private GameObject grid;
	private int MAX_GRID_Y = 5;
	private int MAX_GRID_X = 3;

	//private List<GameObject> platforms;
	// Use this for initialization
	void Start () {
		Game.isGameOver = false;

		print("Loading game");
		grid = GameObject.Find("Grid");
		//platforms = new List<GameObject>();
		for(int i=0; i< MAX_GRID_X; i++) 
			for(int j=0; j< MAX_GRID_Y; j++){

			CreatePlatform(i, j);
		}
	}

	void CreatePlatform(int i, int j){
		GameObject go = Instantiate(platform, new Vector3(i * 2, j * 2, 0), Quaternion.identity) as GameObject;
		go.transform.parent = grid.transform;

		//platforms.Add(go);
	}
	
	// Update is called once per frame
	void Update () {
	}



}
