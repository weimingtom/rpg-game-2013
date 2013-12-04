using UnityEngine;
using System.Collections;

public class Potion : Item {

	int plus = 50;
	
	
	public override void Effect(){
		GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().hp += plus;
	}
}
