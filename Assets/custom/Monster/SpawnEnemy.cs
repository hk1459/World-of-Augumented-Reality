using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public Transform orientTarget;
    public GameObject FollowPlayer;
    private float x1, z1;
    private Vector3 Followpos;
    
    // Use this for initialization
    void Start () {
        if(global.FollowCount >= 1) {

        } else {
            global.FollowCount = 0;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (global.FollowCount < 1)
        {   
            if(Random.Range(0,2) == 0)
            {
                x1 = orientTarget.position.x + UnityEngine.Random.Range(-20.0f, -10.0f);
            } else {
                x1 = orientTarget.position.x + UnityEngine.Random.Range(10.0f, 20.0f);
            }
            if(Random.Range(0,2)==0)
            {
                z1 = orientTarget.position.z + UnityEngine.Random.Range(-20.0f,-10.0f);
            } else{
                z1 = orientTarget.position.z + UnityEngine.Random.Range(10.0f, 20.0f);
            }
            Followpos = new Vector3(x1, .0f, z1);
            GameObject boss = Instantiate(FollowPlayer, Followpos, FollowPlayer.transform.rotation);
            DontDestroyOnLoad(boss);
            FollowPlayer.transform.LookAt(orientTarget);
            global.FollowCount++;
        }
    }


   
}
