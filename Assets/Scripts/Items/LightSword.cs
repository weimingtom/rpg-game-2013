using UnityEngine;
using System.Collections;

public class LightSword : MonoBehaviour {

	int bonus = 4;
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
