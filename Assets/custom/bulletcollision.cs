using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bulletcollision : MonoBehaviour {

  float hp;
  void OnTriggerEnter (Collider col)
  { 
    /*
    GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
    explosion.transform.position = transform.position;
    Destroy(col.gameObject);
    Destroy (explosion, 2);
    */

    if (col.gameObject.tag == "Enemy"){ //hp 기능 추가

        hp = col.gameObject.GetComponent<ingameenemyscript>().Enemyhp;
        hp = hp - 40f;

        if(hp < 0 )
        {
          global.score = global.score + Random.Range(3,5);
          global.gold = global.gold + 5;
          Destroy(col.gameObject);
        }
        col.gameObject.GetComponent<ingameenemyscript>().Enemyhp = hp;
        Destroy(this.gameObject);
    }
    if (col.gameObject.tag == "boss"){ 
      hp = col.gameObject.GetComponent<FollowPlayerCtrl>().bosshp;
      hp = hp - 40;
      if(hp < 0 )
        {
          Destroy(col.gameObject);
          //승리 씬 
        }
      col.gameObject.GetComponent<FollowPlayerCtrl>().bosshp = hp;
      Destroy(this.gameObject);
    }
  }

}