using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class OnClickInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Button button = gameObject.GetComponent<Button>();
		button.onClick.AddListener(delegate() { OnClick(); });

		OnStart();
	}

	public virtual void OnStart(){}

	//override this method on class
	abstract public void OnClick();
}
