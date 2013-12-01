using UnityEngine;
using System.Collections;

public class IronSword : MonoBehaviour {

	int bonus = 7;
	GameObject stat;
	
	
	void Start(){
		stat = GameObject.FindWithTag("Stats");
	}
	
	
	void Equip() {
		stat.GetComponent<CharactersStat>().att += bonus;
	}
	
	
	void Dequip() {
		stat.GetComponent<CharactersStat>().att -= bonus;
	}
}
