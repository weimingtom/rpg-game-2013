using UnityEngine;
using System.Collections;

public class WoodenSword : MonoBehaviour {

	int bonus = 2;
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
