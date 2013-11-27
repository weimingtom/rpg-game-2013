using UnityEngine;
using System.Collections;

public class StatsButton : MonoBehaviour {
	
	public GUIText statsText;
	public GameObject statsObj;
	
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		CharactersStat cs = statsObj.GetComponent(typeof(CharactersStat)) as CharactersStat;
		statsText.text= "Lvl: "+cs.lvl+"\n HP: "+cs.hp+"/"+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.mp+"/"+cs.maxMP+"\n MAG: "+cs.mag+"\n\n Exp: "+cs.exp+"\n To Next Level: "+cs.toLvlExp+"\n\n Gils: "+cs.Gils;
	}
}
