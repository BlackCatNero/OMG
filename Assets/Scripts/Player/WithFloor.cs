using UnityEngine;
using System.Collections;

public class WithFloor : MonoBehaviour {
	public bool withFloor=false;
	public GameObject jumpAnimation;
	
	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag=="Floor"||coll.gameObject.tag=="Slide")
		{
			if(Input.GetButton("Jump")==false)
				audio.Play();
			jumpAnimation.animation.Play();
		}
	}
	
	void OnTriggerStay(Collider coll)
	{
		if(coll.gameObject.tag=="Floor")
			withFloor=true;
		else
			withFloor=false;
	}
	
	void OnTriggerExit()
	{
		withFloor=false;
	}
}
