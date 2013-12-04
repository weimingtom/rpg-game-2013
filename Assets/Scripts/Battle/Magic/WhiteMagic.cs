using UnityEngine;
using System.Collections;

public class WhiteMagic : MonoBehaviour {

	float factor = 1.9f;
	
	void Start () {
		Destroy (gameObject, 1.6f);
	}
	
	
	void OnTriggerEnter(Collider coll){
		if(coll.tag.Equals("Player")){
			GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().hp += (int)(factor * GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().mag);
		}
	}
}
