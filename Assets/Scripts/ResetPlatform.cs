using UnityEngine;
using System.Collections;

public class ResetPlatform : MonoBehaviour {
	public GameObject platform;

	BreakPlatform breakPlatform;

	void Start()
	{
		breakPlatform = platform.GetComponent<BreakPlatform> ();
	}
	
	void GeneratePlatform()
	{
		breakPlatform.isBroken = false;
		platform.transform.position = breakPlatform.originalPosition;
		platform.transform.rotation = new Quaternion (0, 0, 0, 0);
	}
}
