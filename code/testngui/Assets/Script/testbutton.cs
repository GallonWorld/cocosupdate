using UnityEngine;
using System.Collections;

public class testbutton : MonoBehaviour {
	protected bool switchFlag = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		if (this.switchFlag) {
			print("true");
			this.GetComponent<UISprite> ().spriteName = "20140512101542671";
			this.GetComponent<UIButton> ().normalSprite = "20140512101542671";
			this.switchFlag = false;
		} else {
			print("false");
			this.GetComponent<UISprite> ().spriteName = "20140512101531109";
			this.GetComponent<UIButton> ().normalSprite = "20140512101531109";
			this.switchFlag = true;
		}
	}
}
