using UnityEngine;
using System.Collections;

public class BlackMagic : MonoBehaviour {

	float factor = 2.3f;

	void Start () {
		Destroy (gameObject, 1.6f);
	}
	
	
	void OnTriggerEnter(Collider coll){
		if(coll.tag.Equals("Enemy")){
			coll.gameObject.GetComponent<Enemy>().hp -= (int)(factor * GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().mag);
		}
	}
}
