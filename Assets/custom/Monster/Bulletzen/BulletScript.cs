using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	
	// Update is called once per frame
	 void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            global.bullet += 100;
            Destroy(this.gameObject);
            global.bulletcount--;
        }
    }
}
