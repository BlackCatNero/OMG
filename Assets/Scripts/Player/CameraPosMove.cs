using UnityEngine;
using System.Collections;

public class CameraPosMove : MonoBehaviour {
	public Transform playerCamera;
	public Transform player;

	void Update () {
		transform.position=new Vector3(playerCamera.position.x,player.position.y,playerCamera.position.z);
	}
}
