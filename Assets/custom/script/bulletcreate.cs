using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bulletcreate : MonoBehaviour {

  //public GameObject statusText;
  
  void Start()
  {
    //find gameobject have a status Tag
    //statusText = GameObject.FindGameObjectWithTag ("status");
  }  

  public void OnButtonDown(){
    if(global.bullet < 0){

    } else {
      GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
      Rigidbody rb = bullet.GetComponent<Rigidbody>();
      bullet.transform.rotation = Camera.main.transform.rotation;
      bullet.transform.position = Camera.main.transform.position;
      rb.AddForce(Camera.main.transform.forward * 3500f);
      Destroy (bullet, 7);
      //총알 갯수 감소
      global.bullet--;        
    }
    
    //아직 오디오 안넣음
    //GetComponent<AudioSource> ().Play ();
  }
}