using UnityEngine;
using System.Collections;

public class Magic : MonoBehaviour {


	void Start () {
		Destroy (gameObject, 1.6f);
	}
	

	void OnTriggerEnter(Collider coll){
		if(coll.tag.Equals("Player")){
			MovementBattle mb = coll.gameObject.GetComponent(typeof(MovementBattle)) as MovementBattle;
			mb.CharacterDamage();
		}
	}
}