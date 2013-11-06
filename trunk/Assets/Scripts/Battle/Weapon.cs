using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public GameObject character;
	void Start () {
		
	}
	
	void Update () {
		if(character==null){
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider collider){
		if(collider.tag.Equals("Enemy")){
			
			MovementBattle mb = character.GetComponent(typeof(MovementBattle)) as MovementBattle;
			if(mb.attacking){
				Enemy en = collider.GetComponent(typeof(Enemy)) as Enemy;
				en.Damaged();
			}
		}
	}
}
