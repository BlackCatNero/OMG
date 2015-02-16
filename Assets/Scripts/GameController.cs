using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public bool pause=false;
	public MouseOrbit mouseOrbit;
	
	void Start()
	{
		Screen.showCursor=false;
	}
	
	void Update ()
	{
		mouseOrbit=GameObject.Find("플레이어 카메라").GetComponent<MouseOrbit>();
		
		if(pause==false&&Input.GetKeyDown(KeyCode.Escape))
		{
			mouseOrbit.target=null;
			Screen.showCursor=true;
			Time.timeScale=0;
			pause=true;
		}
		
		else if(pause&&Input.GetKeyDown(KeyCode.Escape))
		{
			Screen.showCursor=false;
			Time.timeScale=1;
			mouseOrbit.target=GameObject.Find("플레이어 그래픽").transform;
			pause=false;
		}
	}
	
	void OnLevelWasLoaded()
	{
		audio.Play();
	}
	
	void OnGUI()
	{
		if(pause)
		{
			if(GUI.Button(new Rect(Screen.width/2-125,Screen.height/2-45,250,30),"Resume Game"))
			{
				Screen.showCursor=false;
				Time.timeScale=1;
				mouseOrbit.target=GameObject.Find("플레이어 그래픽").transform;
				pause=false;
			}
			else if(GUI.Button (new Rect(Screen.width/2-125,Screen.height/2+15,250,30),"Exit Game"))
			{
				Application.Quit();
			}
		}
	}
}
