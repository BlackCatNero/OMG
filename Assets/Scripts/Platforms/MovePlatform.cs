using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour
{
	public Transform point1;
	public Transform point2;
	public float moveSpeed;
	public Vector3 positionBefore;
	public bool isPlayerOn=false;
	
	void FixedUpdate () 
	{
		float weight=Mathf.Cos(Time.fixedTime*moveSpeed*0.02f*Mathf.PI)*0.5f+0.5f;
		positionBefore=transform.position;
		transform.position=point1.position*weight+point2.position*(1-weight);
		if(isPlayerOn)
			GameObject.Find ("플레이어 그래픽").transform.position+=transform.position-positionBefore;
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