using UnityEngine;
using UnityEditor;
using System.Collections;

[InitializeOnLoad]
public class Scriptreader {

	private static string fileWithScript = "firstSequence";
	private static XMLParser parser;

	static Scriptreader()
	{
		Debug.Log("Up and running");
		parser = new XMLParser();
		var textAsset = (TextAsset) Resources.Load(fileWithScript);
		if (parser != null && textAsset != null) {
			var node = (XMLNode) parser.Parse (textAsset.text);
			if (node != null) {
				var EventList = node.GetNodeList("plist>0>array>0>dict");
				foreach(XMLNode Event in EventList) {
					Debug.Log (Event);
					var setting = Event.GetNode ("key>0");
					Debug.Log (setting);
				}
			}
		} else {
			Debug.LogWarning ("Could Not Load or Parse the xml");
		}
	}

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
