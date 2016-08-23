using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {
	
	private GameObject selected;
	// Use this for initialization
	void Start () {
		selected = GameObject.Find("Selected");
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit ;
		if (Physics.Raycast (ray, out hit) && (hit.transform.tag == "Platform" /*|| hit.transform.name == "Cube"*/)) {
			Vector3 v = hit.point;
			v.z = 0;
			selected.transform.position = hit.transform.position;

			Platform p = hit.transform.GetComponent<Platform>();
			p.selected = true;
			if (p.color == Color.red){
				Game.GameOver();
				//Application.LoadLevel(Application.loadedLevel);

			}
		}
	}


}
