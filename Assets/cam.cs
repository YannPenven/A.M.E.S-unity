using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {
	WebCamTexture cameraBack;
	public int count = 0;
	private bool Active;
	private AndroidJavaObject camera1;
	// Use this for initialization
	void Start () {
		cameraBack = new WebCamTexture ();
		GetComponent<Renderer> ().material.mainTexture = cameraBack;
		//Debug.LogError("[CameraParametersAndroid] qzqqzdqdz");
		cameraBack.Play ();
		//StartFlashLight ();
	}
	
	// Update is called once per frame
	void Update () {
		count++;
	
	}

	void StartFlashLight() {
		AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");       
		//WebCamDevice[] devices = WebCamTexture.devices;
		//Debug.LogError("[CameraParametersAndroid] Flashlight");
		//int camID = 0;
		camera1 = cameraClass.CallStatic<AndroidJavaObject>("open", 0);

		if (camera1 != null)
		{
			AndroidJavaObject cameraParameters = camera1.Call<AndroidJavaObject>("getParameters");
			cameraParameters.Call("setFlashMode", "torch");
			camera1.Call("setParameters", cameraParameters);
			///FIX///// 
			camera1.Call("startPreview");
			Active = true;
		}
		else
		{
			Debug.LogError("[CameraParametersAndroid] Camera not available");
		}
	}

	void OnDestroy()
	{
		FL_Stop();
	}

	void FL_Stop()
	{

		if (camera1 != null)
		{
			camera1.Call("stopPreview");
			camera1.Call("release");
			Active = false;
		}
		else
		{
			Debug.LogError("[CameraParametersAndroid] Camera not available");
		}

	}
}
