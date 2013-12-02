using UnityEngine;
using System.Collections;

public class CharactersStat : MonoBehaviour {
	
	public int hp = 230;
	public int maxHP = 230;
	public int mp = 100;
	public int maxMP = 100;
	public int att = 10;
	public int def = 4;
	public int mag = 9;
	public int lvl = 1;
	public int exp = 0;
	public int Gils = 0;
	public int toLvlExp = 300;
	public int critical;
	public GUIText charGUI;
	string Status = "Normal";
	int prevToNextLvl;
	public bool leveledUp = false;
	
	void Start(){
		prevToNextLvl = toLvlExp;
	}
	public void LevelUp(){
		if(toLvlExp <= 0){
			lvl ++;
			maxHP+= Random.Range(2,5);
			att += Random.Range(1,4);
			def += Random.Range(1,3);
			maxMP += Random.Range(2,5);
			mag += Random.Range(1,3);
			toLvlExp += (prevToNextLvl + 250);
			prevToNextLvl = toLvlExp;
			leveledUp = true;
		}
	}

}
