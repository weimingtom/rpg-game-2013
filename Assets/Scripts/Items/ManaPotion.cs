using UnityEngine;
using System.Collections;

public class ManaPotion : Item {
	int plus = 50;
	// Use this for initialization
	public override void Effect(){
		GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().mp += plus;
	}
}
