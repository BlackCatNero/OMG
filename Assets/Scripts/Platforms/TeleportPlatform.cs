using UnityEngine;
using System.Collections;

public class TeleportPlatform : MonoBehaviour {
	public int sceneName=0;
	public Transform top;
	
	void FixedUpdate()
	{
		transform.Rotate(0,1,0);
		top.Rotate(0,-2,0);
	}
	
	void OnTriggerEnter()
	{
		Application.LoadLevel(sceneName);
	}
}
