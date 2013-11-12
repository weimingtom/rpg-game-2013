using UnityEngine;
using System.Collections;

public class WeaponPos : MonoBehaviour {
	public GameObject posObj;
	public GameObject wielder;
	
	void Start () {
	}
	
	void FixedUpdate () {
		if(wielder!=null){
			transform.position = posObj.transform.position;
			transform.rotation = wielder.transform.rotation;
		}
		
	}
}
