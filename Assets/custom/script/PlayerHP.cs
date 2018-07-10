using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHP : MonoBehaviour {
	public GameObject playerHp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(global.hp <= 0)
		{
			//게임 종료 씬 로딩 코드 추가 

			playerHp.transform.localScale = new Vector3( 0 , playerHp.transform.localScale.y, playerHp.transform.localScale.z);
			SceneManager.LoadScene(2); //deadScene
		} else {
			playerHp.transform.localScale = new Vector3(global.hp/100f , playerHp.transform.localScale.y, playerHp.transform.localScale.z);
		}
	}
}
