using UnityEngine;
using System.Collections;

public class DamageTextScr : MonoBehaviour {

	public GameObject target;
	Vector3 offset = new Vector3(-0.2f,1.3f,0f);
	
	void Update(){
		
		//transform.position = Vector3.Lerp(transform.position, target.transform.position, 6f);
		if(target !=null){
			transform.position = target.transform.position +offset;
		}
		/*if(dif.magnitude >= 8f){
			
		}*/
	}
}
