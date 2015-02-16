using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public AudioClip newMusic;
	
	GameObject go;
	
	void Awake()
	{
		go=GameObject.Find("배경음악");
		if(go.audio.clip!=newMusic)
		{
			go.audio.clip=newMusic;
			go.audio.Play();
		}
	}
}
