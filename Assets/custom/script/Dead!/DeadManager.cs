using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeadManager : MonoBehaviour {

	public GameObject DeadText;
	// Use this for initialization
	void Start () {
		DeadText.GetComponent<Text>().text = "Your Score : " + global.score;
        PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
