using UnityEngine;
using System.Collections;

public class Egg : Item {
	int plus = 10;
	public override void Effect(){
		GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().hp += plus;
	}
}
