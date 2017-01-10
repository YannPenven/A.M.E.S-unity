using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	bool _pressed = false;
	// Use this for initialization
	void Start () {
		
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		_pressed = true;
		Debug.LogWarning ("button has been pressed");
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		_pressed = false;
	}

	void Update()
	{
		if (!_pressed)
			return;

		// DO SOMETHING HERE
	}

}
