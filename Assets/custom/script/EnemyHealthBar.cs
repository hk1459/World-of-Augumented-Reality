using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour {

	public GameObject EnemyHpBar;
	public float Enemyhp = 100f;

	// Use this for initialization
	void Start () {}
	
	
	// Update is called once per frame
	void Update () {
		if(Enemyhp < 0){
			Destroy(this);
		}
		EnemyHpBar.transform.localScale = new Vector3(Enemyhp / 100f, EnemyHpBar.transform.localScale.y, EnemyHpBar.transform.localScale.z);
	}
}
