using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gotomap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void aaaaaaaa()
	{
		PlayerPrefs.SetFloat("hp", global.hp); 
		PlayerPrefs.SetInt("bullet", global.bullet); 
		PlayerPrefs.SetInt("gold", global.gold); 
		PlayerPrefs.SetInt("score", global.score); 
		SceneManager.LoadScene(0);
	}
}
