using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
	public float speed=0.2f;	// 플레이어 속도
	public float jumpSpeed=15;	// 점프 속도
	public WithFloor onFloor;   // 바닥 접촉 확인
	
	public float audioUpdateInterval=0.3f; //점프 사운드 간격
	double lastInterval;
	float timeNow;

	public Material playerGreen;
	
	void FixedUpdate ()
	{
		transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * -speed);
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * -speed);
		
		timeNow=Time.realtimeSinceStartup;
		
		if(Input.GetButton("Jump")&&onFloor.withFloor)
		{
			gameObject.animation.Play ();
			rigidbody.velocity=new Vector3(0,jumpSpeed,0);
			if(timeNow>lastInterval+audioUpdateInterval)
			{
				gameObject.audio.Play();
				lastInterval=timeNow;
			}
		}
	}

	void Update()
	{
		InputColorChange ();
	}

	private void InputColorChange()
	{
		if (Input.GetKeyDown(KeyCode.R))
			ChangeColorTo(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
	}
	
	[RPC] void ChangeColorTo(Vector3 color)
	{
		renderer.material.color = new Color(color.x, color.y, color.z, 1f);
		playerGreen.color = renderer.material.color;
	}
}
