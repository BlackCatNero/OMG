using UnityEngine;
using System.Collections;

public class MouseOrbit : MonoBehaviour {
	public Transform target;
	public float distance=10.0f;
	public float xSpeed=250.0f;
	public float ySpeed=120.0f;
	public float yMinLimit=-20.0f;
	public float yMaxLimit=80.0f;
	
	float x=0.0f;
	float y=0.0f;

	void Start () {
		x=transform.eulerAngles.y;
		y=transform.eulerAngles.x;
		if(rigidbody)
			rigidbody.freezeRotation=true;
	}
	
	void LateUpdate () {
		if(target)
		{
			x+=Input.GetAxis("Mouse X")*xSpeed*0.02f;
			y-=Input.GetAxis("Mouse Y")*ySpeed*0.02f;
			y=ClampAngle(y,yMinLimit,yMaxLimit);
			transform.rotation=Quaternion.Euler(y, x, 0);
			transform.position=Quaternion.Euler(y, x, 0)*new Vector3(0.0f, 0.0f, -distance)+target.position;
		}
	}
	
	float ClampAngle(float angle,float min,float max)
	{
		if(angle<-360)
			angle+=360;
		if(angle>360)
			angle-=360;
		return Mathf.Clamp(angle,min,max);
	}
}
