using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Bulletcreate : MonoBehaviour {

    
    public Transform Player;
    public GameObject bullet;
    private float x, z;
    private int Count;

    private Vector3 bulletpos;
    // Use this for initialization
    void Start()
    {
        if(global.bulletcount > 5){

        } else {
            global.bulletcount = 0;
        }
        
        StartCoroutine(bulletgen());
    }

    IEnumerator bulletgen() 
    {   
        while(global.bulletcount <= 5){
            if(SceneManager.GetActiveScene().buildIndex == 0)
                {
                    if(Random.Range(0,2) == 0){
                        x = Player.position.x + UnityEngine.Random.Range(-30.0f, -12.0f);
                     } else {
                        x = Player.position.x + UnityEngine.Random.Range(12.0f, 30.0f);
                     }
                      if(Random.Range(0,2) == 0){
                        z = Player.position.z + UnityEngine.Random.Range(-30.0f, -12.0f);
                      } else {
                        z = Player.position.z + UnityEngine.Random.Range(12.0f, 30.0f);
                      }
                bulletpos = new Vector3(x, 3f, z);
                GameObject bul = Instantiate(bullet, bulletpos, bullet.transform.rotation);
                DontDestroyOnLoad(bul);
                global.bulletcount++;
                }
            yield return new WaitForSeconds(5f);

        }
        
        
    }   

}
