using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnboss : MonoBehaviour {
	
   	public GameObject FollowPlayer;
   	private float x1, z1;
    private Vector3 Followpos;
	// Use this for initialization
	void Start () {
		if(true){
            if(Random.Range(0,2) == 0)
            {
                x1 = UnityEngine.Random.Range(-20.0f, -10.0f);
            } else {
                x1 = UnityEngine.Random.Range(10.0f, 20.0f);
            }
            if(Random.Range(0,2)==0)
            {
                z1 = UnityEngine.Random.Range(-20.0f,-10.0f);
            } else{
                z1 = UnityEngine.Random.Range(10.0f, 20.0f);
            }
            Followpos = new Vector3(x1, .0f, z1);
            Instantiate(FollowPlayer, Followpos, FollowPlayer.transform.rotation);
            FollowPlayer.transform.LookAt(new Vector3(0,0,0));

            global.bossentro = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
