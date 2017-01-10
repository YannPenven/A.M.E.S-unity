using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HUDEvent : MonoBehaviour {

	private int eventListPointer;
	private List<string> eventList;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		//startFlash ();

	}

	void interpreter() {
		var prefab = new GameObject ();
		var vect = new Vector3 ();

		for (int i = this.eventListPointer; i < eventList.Count; i++) {
			switch (eventList [i]) {
			case "button":
				prefab = Resources.Load ("ButtonPrefab") as GameObject;
				vect = new Vector3 (0, 0, 0);
				addGameObjectToCanvas (prefab, vect);
				break;
			case "text":
				prefab = Resources.Load ("ButtonPrefab") as GameObject;
				vect = new Vector3 (0, 0, 0);
				addGameObjectToCanvas (prefab, vect);
				break;
			default:
				Debug.LogError ("Error in interpreting the script");
				break;
			}
		}
	}

	void addGameObjectToCanvas (GameObject objectToAdd, Vector3 position) {
		GameObject instance = Instantiate (objectToAdd, transform.position, transform.rotation) as GameObject;
		instance.transform.parent = this.gameObject.transform;
	}


}
