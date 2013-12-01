using UnityEngine;
using System.Collections;

public class EnemyWeapon : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnTriggerEnter(Collider coll){
		if(coll != null)
			if(coll.tag.Equals("Player")){
				MovementBattle mb = coll.gameObject.GetComponent(typeof(MovementBattle)) as MovementBattle;
				gameObject.renderer.material.color = Color.red;
				mb.CharacterDamage();
			}
			else{
				gameObject.renderer.material.color = Color.gray;
		}Debug.Log(coll.tag);
	}
}
