using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeadBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart()
	{	
		//아마도 dondestroy onLoad에 있는거 안 삭제 될 것임 . 완전히 재시작 하는 방법 필요
		
		
		SceneManager.LoadScene(0);
	}
	public void Exit()
	{
		Application.Quit();
	}
}
