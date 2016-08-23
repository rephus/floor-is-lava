using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour {

	private Text time;
	// Use this for initialization
	void Start () {
		time = GameObject.Find("GameTime").GetComponent<Text>() as Text ;
	}
	
	// Update is called once per frame
	void Update () {	
		time.text = "" +Time.timeSinceLevelLoad ;
	}
}
