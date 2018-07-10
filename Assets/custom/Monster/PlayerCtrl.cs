using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCtrl : MonoBehaviour {
    
    
   // Use this for initialization
   void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "PUNCH")
        {
            global.hp -= 5;
        }
    }
    
}