using UnityEngine;
using System.Collections;

public class AccelPlatform : MonoBehaviour {
    public float moveSpeed = 1.0f;
	public Vector3 positionBefore;
	public bool isPlayerOn=false;
	
	void Update () 
	{
		if (isPlayerOn)
			GameObject.Find ("플레이어 그래픽").transform.position += transform.forward * moveSpeed * 0.1f;
	}
	
	void OnTriggerStay(Collider coll)
	{
		if(coll.gameObject.tag=="Player")
			isPlayerOn=true;
		else
			isPlayerOn=false;
	}
	
	void OnTriggerExit(Collider coll)
	{
		isPlayerOn=false;
	}
}
