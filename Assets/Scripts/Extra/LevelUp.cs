using UnityEngine;
using System.Collections;

public class LevelUp : MonoBehaviour {
	public GameObject stats;
	public Bridge bridge;
	public GUIText winText;
	public GUIText LevelUpText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		winText.text = "Exp Gained: " + bridge.totalExp + "\n Gil: " + bridge.totalGil;
		if(cs.leveledUp)
			LevelUpText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
	}
}
