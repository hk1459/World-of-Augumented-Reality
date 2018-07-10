using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
public class spawningame : MonoBehaviour {

	public GameObject enemyobj;
      private float timer;
      private GameObject victoryText;
      int enemycount;
      void Awake() {
            victoryText = GameObject.FindGameObjectWithTag("Victory");
            victoryText.GetComponent<Text>().text = "";
      }
	void Start () 
	{
            timer = 0f;
            enemycount = Random.Range(5,10);
		enemyobj.transform.LookAt(new Vector3(0,0,0));
    	      StartCoroutine(ObjectRandomGenerator()); 
	} 

	IEnumerator ObjectRandomGenerator() 
	{ 
            while(enemycount >= 0) { 

                  //일정 범위 밖에서 구체 생성 해야함 . 
                  if(SceneManager.GetActiveScene().buildIndex == 1)
                  {
                        int rand = 0;
                        int rand2 = 0;
                        if(Random.Range(0,2) == 0){
                              rand = Random.Range(-100,-30);
                        } else {
                              rand = Random.Range(30,100);
                        }
                        if(Random.Range(0,2) == 0){
                              rand2 = Random.Range(-100,-30);
                        } else {
                              rand2 = Random.Range(30,100);
                        }
                        int rand3 = Random.Range(-30,30);
                        
                  		
                  	
                        GameObject enemy = Instantiate(enemyobj, enemyobj.transform.localPosition , Quaternion.identity);
                        
                        enemy.transform.position = new Vector3 ( rand2 , rand3 , rand);
                        enemy.transform.LookAt(new Vector3(0,0,0));

                        GameObject hpbar = GameObject.FindWithTag("HPbar");
                        hpbar.transform.LookAt(new Vector3(0,0,0));
                        //text.GetComponent<Text>().text = "enemy : " + global.count;
                        enemycount--;
                  }
                  yield return new WaitForSeconds(2.5f); 
            } 
	} 

      void Update()
      {
            
            if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && !global.bossentro)
            {
                  //전투 승리 
                  PlayerPrefs.SetFloat("hp", global.hp); 
                  PlayerPrefs.SetInt("bullet", global.bullet); 
                  PlayerPrefs.SetInt("gold", global.gold); 
                  int random = Random.Range(20,51);
                  PlayerPrefs.SetInt("score", global.score + random); 
                  victoryText.GetComponent<Text>().text = "Victory!!\r\n Bonus Score + " + random;

                  while(timer < 3f ) {
                        timer = timer + Time.deltaTime;
                  }
                  
                  SceneManager.LoadScene(0);
            }

      }
      

}
