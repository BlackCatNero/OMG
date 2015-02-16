using UnityEngine;
using System.Collections;

public class SmoothLookAt : MonoBehaviour {
	public Transform target;
	public float damping=6.0f;
	public bool smooth=true;
	
	void Start()
	{
		if(rigidbody)
			rigidbody.freezeRotation=true;
	}
	
	void LateUpdate()
	{
		if(target)
		{
			if(smooth)
			{
				transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(target.position-transform.position),Time.deltaTime*damping);
			}
			
			else
				transform.LookAt(target);
		}
	}
}
