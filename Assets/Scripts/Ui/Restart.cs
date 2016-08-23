using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Restart : OnClickInterface {

	public override void OnClick(){

		Application.LoadLevel(Application.loadedLevel);
	}
}
