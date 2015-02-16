using UnityEngine;
using System.Collections;

public class BreakPlatform : MonoBehaviour {
	public bool alwaysBreak = false;
	public GameObject breakSound;
	public float breakTime=3.0f;
	public float rotateScale=5.0f;

	public float landTime;
	public float timeNow;
	public bool isBroken=false;

	public Vector3 originalPosition;

	void Start()
	{
		originalPosition = transform.position;
	}

	void OnTriggerEnter()
	{
		landTime = timeNow;
		if (alwaysBreak) 
		{
			gameObject.audio.Play ();
			gameObject.animation.Play ();
			Invoke ("PlatformBreak", 0.5f);
		}
	}

	void OnTriggerStay()
	{
		if (timeNow > landTime + breakTime / 2) 
		{
				transform.Rotate (0, rotateScale, 0);
				rotateScale = -rotateScale;
		}

		if (timeNow > landTime + breakTime) 
		{
			gameObject.audio.Play ();
			gameObject.animation.Play();
			Invoke("PlatformBreak",0.5f);
		}
	}
	
	void OnTriggerExit()
	{
		if (Input.GetButton ("Jump")) 
		{
			gameObject.audio.Play ();
			gameObject.animation.Play ();
			Invoke ("PlatformBreak", 0.5f);
		} 


	}
	
	void FixedUpdate()
	{
		timeNow = Time.realtimeSinceStartup;
		if(isBroken)
			transform.position = new Vector3 (1000.0f, 1000.0f, 1000.0f);
	}

	void PlatformBreak()
	{
		isBroken = true;
	}
}
