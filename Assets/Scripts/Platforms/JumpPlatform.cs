using UnityEngine;
using System.Collections;

public class JumpPlatform : MonoBehaviour {
	public float jumpPower;
	public bool isSound=true;
	
	void OnTriggerEnter(Collider coll)
	{
		GameObject.Find("플레이어 그래픽").rigidbody.velocity=new Vector3(0,jumpPower,0);
		GameObject.Find("플레이어 그래픽").animation.Play();
		if(isSound)
			audio.Play();
	}
}
