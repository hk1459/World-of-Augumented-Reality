using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingameenemyscript : MonoBehaviour {

	public GameObject Sphere;
	public GameObject statusText;
	// Use this for initialization

	public GameObject EnemyHpBar;

	public float Enemyhp = 100f;
	void Start () {
		statusText = GameObject.FindGameObjectWithTag ("Status");
		}
	
	// Update is called once per frame
	// 0,0,0 으로 다다다게 . 그러면서 일정 범위 내 ex) 원점과의 거리를 구한 후에 
	// destroy 한 후에 count --  하고 (global 변수 접근)
	// 카메라 하나 더 만들어서 유니티 좌표상의 적들의 움직임을 대략적으로 보여주는 미니맵 카메라 생성 ..
	void Update () {
	if(statusText == null) {
		statusText = GameObject.FindGameObjectWithTag ("Status");
	}
	
	float dis = Vector3.Distance(new Vector3(0,0,0), Sphere.transform.position); 
	if(dis < 3){
		//hp 감소 이벤트 . global 변수 ? 
		Destroy(Sphere);
		global.hp = global.hp - 10f;
		statusText.GetComponent<Text>().text = "HP: " +global.hp + " Bullet: " + global.bullet;
	}

	float mWalkingSpeed = 7f;
    // 이동할 방향을 구한다. (directionOfTravel = 이동할 방향벡터)
    Vector3 directionOfTravel = 
    //플레이어 포지션으로 바꿀것. not 0 0 0
    new Vector3(0,0,0) - Sphere.transform.position;

    // 크기가 표준화된 노멀라이징벡터를 구하고 
	directionOfTravel.Normalize();

    // 해당하는 방향으로 이동을 시켜주도록한다. 
	this.transform.Translate(
        (directionOfTravel.x * mWalkingSpeed * Time.deltaTime),
        (directionOfTravel.y * mWalkingSpeed * Time.deltaTime),
        (directionOfTravel.z * mWalkingSpeed * Time.deltaTime),
        Space.World);

    //hpbar setting
    EnemyHpBar.transform.localScale = new Vector3(Enemyhp / 100f, EnemyHpBar.transform.localScale.y, EnemyHpBar.transform.localScale.z);
	
	}

}
