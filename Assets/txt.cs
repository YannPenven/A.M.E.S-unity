using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class txt : MonoBehaviour {

	Text txte;

	// Use this for initialization
	void Start () {
		txte = gameObject.GetComponent<Text>(); 
	}

	// Update is called once per frame
	void Update () {
		txte.text="Score : " + "";  
	}

}
