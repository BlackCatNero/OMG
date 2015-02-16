using UnityEngine;
using System.Collections;

public class PortalPlatform : MonoBehaviour {
	public Transform portal;
	public Transform top;
	public float changedVelocity=30.0f;

	void FixedUpdate()
	{
		transform.Rotate(0,1,0);
		top.Rotate(0,-2,0);
	}
	
	void OnTriggerEnter()
	{
		GameObject.Find ("플레이어 그래픽").transform.position = portal.position;
		GameObject.Find ("플레이어 그래픽").rigidbody.velocity = Vector3.up*changedVelocity;
		audio.Play ();
	}
}