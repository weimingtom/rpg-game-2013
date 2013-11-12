using UnityEngine;
using System.Collections;

public class CameraObj : MonoBehaviour {
	
	public GameObject target;
	Vector3 offset = new Vector3(0f,8f,-6f);
	
	void FixedUpdate(){
		if(target!=null){
			transform.position = target.transform.position +offset;
		}
	}

}
