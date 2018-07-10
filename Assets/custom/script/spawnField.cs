using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class spawnField : MonoBehaviour {

	public GameObject enemyobj;
	public GameObject text;
      public GameObject player;

	void Start () 
	{ 
		enemyobj.transform.LookAt(new Vector3(0,0,0));
            player = GameObject.FindWithTag("Player");
    	      StartCoroutine(ObjectRandomGenerator()); 

            while(global.count < 5)
            {
                  //일정 범위 밖에서 구체 생성 해야함 . 
                  int rand = 0;
                  int rand2 = 0;
                  if(Random.Range(0,2) == 0){
                        rand = Random.Range(-70,-15);
                  } else {
                        rand = Random.Range(15,70);
                  }
                  if(Random.Range(0,2) == 0){
                        rand2 = Random.Range(-70,-15);
                  } else {
                        rand2 = Random.Range(15,70);
                  }
                  int rand3 = Random.Range(10,40);
                  
                        
                  
                  GameObject enemy = Instantiate(enemyobj, enemyobj.transform.localPosition , Quaternion.identity);
                  
                  enemy.transform.position = new Vector3 ( rand2 , rand3 , rand);
                  enemy.transform.LookAt(new Vector3(0,0,0));

                  DontDestroyOnLoad (enemy); 
                  //if()
                  global.count++;
                  text.GetComponent<Text>().text = "enemy : " + global.count;
                  
            }
	} 

	IEnumerator ObjectRandomGenerator() 
	{ 
      while(true) { 
            //플레이어 기준 일정 범위 밖에서 구체 생성 해야함 . 
            if(SceneManager.GetActiveScene().buildIndex == 0)
                  {     
                        if(global.count > 15)
                        {
                              yield return new WaitForSeconds(5f);
                        }
                        if(player == null)
                        {
                              player = GameObject.FindWithTag("Player");
                        }
                        int rand = 0;
                        int rand2 = 0;
                        if(Random.Range(0,2) == 0){
                              rand = Random.Range(-70,-20);
                        } else {
                              rand = Random.Range(20,70);
                        }
                        if(Random.Range(0,2) == 0){
                              rand2 = Random.Range(-70,-20);
                        } else {
                              rand2 = Random.Range(20,70);
                        }
                        int rand3 = Random.Range(10,40);
                        
                  		
                  	
                        GameObject enemy = Instantiate(enemyobj, enemyobj.transform.localPosition , Quaternion.identity);
                        
                        enemy.transform.position = player.transform.position + new Vector3 ( rand2 , rand3 , rand);
                        enemy.transform.LookAt(new Vector3(0,0,0));

                        DontDestroyOnLoad(enemy);
                  
                        //if()
                        global.count++;
                        text.GetComponent<Text>().text = "enemy : " + global.count;
                  }
            yield return new WaitForSeconds(10f); 
            } 
	} 

}
