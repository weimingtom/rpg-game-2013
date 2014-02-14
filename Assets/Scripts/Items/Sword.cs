using UnityEngine;
using System.Collections;

public class Sword : Item {

	protected int bonus = 0;
	GameObject stat;
	bool equipped = false;
	
	void Start(){
		stat = GameObject.FindWithTag("Stats");
		equipable = true;
	}
	
	
	public void Equip() {
		if(!equipped){
			stat.GetComponent<CharactersStat>().att += bonus;
			equipped = true;
		}
	}
	
	
	public void Dequip() {
		if(equipped){
			stat.GetComponent<CharactersStat>().att -= bonus;
			equipped = false;
		}
	}

	public override void Effect(){}
}
