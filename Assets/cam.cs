using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {
	WebCamTexture camera;
	public int count = 0;
	// Use this for initialization
	void Start () {
		camera = new WebCamTexture ();
		GetComponent<Renderer> ().material.mainTexture = camera;
		camera.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		count++;
	
	}
}
