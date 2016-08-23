using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public Color color = Color.green;
	public bool selected = false;
	// Use this for initialization
	void Start () {
    	InvokeRepeating ("ChangeColor", 0, 1); 
	}
	
	void Update () {
	}

	void ChangeColor(){
		if (Game.isGameOver) return;

		int random = Random.Range(0, 2);

		if (color == Color.green){
			if (selected || random == 1){
				color = Color.yellow;
			}
		} else if( color == Color.yellow){
			if (random == 1) color = Color.red;
		} else if (color == Color.red){
			if (random == 1) color = Color.green;
		}
		this.GetComponent<Renderer>().material.color = color;

		selected = false;
	}
}
