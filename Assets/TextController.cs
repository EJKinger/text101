using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Space bar to begin...";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			text.text = "Welcome to my Text Adventure!!! " +
						"Hit the space bar to continue on :)";
		}
	}
}
