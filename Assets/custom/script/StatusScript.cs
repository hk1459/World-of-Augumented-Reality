using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatusScript : MonoBehaviour {
	public GameObject Statustext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Statustext == null)
		{
			Statustext = GameObject.FindGameObjectWithTag("Status");
		}
		Statustext.GetComponent<Text>().text = " Bullet : " + global.bullet + " Gold : " + global.gold + " Score : " + global.score ; 
    
		
	}
}
