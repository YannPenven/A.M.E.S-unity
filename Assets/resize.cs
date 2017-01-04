using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class resize : MonoBehaviour {

	double worldScreenHeight;
	double worldScreenWidth;

	// Use this for initialization
	void Start () {
		this.worldScreenWidth = Camera.main.orthographicSize * 2.0;
		this.worldScreenHeight = worldScreenHeight / Screen.height * Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
		var newWorldScreenWidth = Camera.main.orthographicSize * 2.0;
		var newWorldScreenHeight = worldScreenHeight / Screen.height * Screen.width;
		if (newWorldScreenHeight != this.worldScreenHeight || newWorldScreenWidth != this.worldScreenWidth) {
			
		}
	}


}
