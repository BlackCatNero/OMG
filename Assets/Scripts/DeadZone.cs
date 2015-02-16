using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour
{
	void OnCollisionEnter(Collision col)
	{
		// 충돌한 객체의 태그가 Player인 경우
		if(col.gameObject.tag == "Player")
		{
			// 사망 씬으로 보낸다
			Debug.Log("Dead!");
			GameObject[] resetPlatforms;
			resetPlatforms=GameObject.FindGameObjectsWithTag("ResetPlatform");
			for(int i=0;i<resetPlatforms.Length;i++)
			{
				resetPlatforms[i].SendMessage("GeneratePlatform");
			}
			col.gameObject.transform.position=GameObject.FindWithTag("Respawn").transform.position;
			col.gameObject.rigidbody.velocity=new Vector3(0,0,0);
			audio.Play();
			GameObject.Find("리스폰 파티클").particleSystem.Play();
		}
	}
}
