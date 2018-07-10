using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Fieldenemyscript : MonoBehaviour {

	public GameObject Sphere;
	public GameObject player;

	// Use this for initialization
	
	void Start () {
		player = GameObject.FindWithTag("Player");
		StartCoroutine(SphereUpdater());
	}
	
	
	IEnumerator SphereUpdater()
	{
		while(true) {
			if(SceneManager.GetActiveScene().buildIndex == 0)
			{
				if(player == null)
				{
					player = GameObject.FindWithTag("Player");
				}
				float dis = Vector3.Distance(player.transform.position, Sphere.transform.position); 
				if(dis < 5){
					Destroy(Sphere);
					global.count--;

					//이벤트 발생. 신 전환
					SceneManager.LoadScene(1); // 일정 거리 이내 일 때 event 발생
					break;
				}
				float mWalkingSpeed = 3f;



			    // 이동할 방향을 구한다. (directionOfTravel = 이동할 방향벡터)
			    Vector3 directionOfTravel = 
			    //플레이어 포지션으로 바꿀것. not 0 0 0
			    player.transform.position - Sphere.transform.position;

			    // 크기가 표준화된 노멀라이징벡터를 구하고 

			    directionOfTravel.Normalize();

			    // 해당하는 방향으로 이동을 시켜주도록한다. 

			    this.transform.Translate(
			        (directionOfTravel.x * mWalkingSpeed * Time.deltaTime),
			        (directionOfTravel.y * mWalkingSpeed * Time.deltaTime),
			        (directionOfTravel.z * mWalkingSpeed * Time.deltaTime),
			        Space.World);

			}
		    yield return new WaitForSeconds(0.05f);
		}
	}
}
