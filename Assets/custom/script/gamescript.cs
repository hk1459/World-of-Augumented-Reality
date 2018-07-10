using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamescript : MonoBehaviour {
	void Awake()
	{	
		
		if(PlayerPrefs.GetFloat("hp") == 0)
		{
			global.hp = 100f;
			global.bullet = 100;
			global.gold = 0;
			global.score = 0;
		}
		else 
		{
			global.hp =  PlayerPrefs.GetFloat("hp");
			global.bullet =  PlayerPrefs.GetInt("bullet");
			global.gold =  PlayerPrefs.GetInt("gold");
			global.score =  PlayerPrefs.GetInt("score");
		}
		
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{	
			PlayerPrefs.SetFloat("hp", global.hp); 
			PlayerPrefs.SetInt("bullet", global.bullet); 
			PlayerPrefs.SetInt("gold", global.gold); 
			PlayerPrefs.SetInt("score", global.score); 
			Application.Quit();
		}
	}
}
