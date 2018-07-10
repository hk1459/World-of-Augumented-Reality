using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubesc : MonoBehaviour {
	public GameObject ARCAM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = new Quaternion(0 , ARCAM.transform.rotation.y ,0, ARCAM.transform.rotation.w);
		
	}
}
