using UnityEngine;
using System.Collections;

public class ButtonLevelUp : MonoBehaviour {
	public GameObject overworld;
	public GameObject dungeon;
	//public GameObject battle;
	public GameObject playerOverW;
	public GameObject stats;
	public GameObject LevelUp;
	public GUIText lvlUpText;
	public Bridge bridge;
	public MovementWorld mw;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	// Update is called once per frame
	void OnMouseDown () {
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		cs.leveledUp = false;
		MovementWorld pj = playerOverW.GetComponent(typeof(MovementWorld)) as MovementWorld;
		pj.enabled = true;
		lvlUpText.text = "";
		bridge.totalExp = 0;
		bridge.totalGil = 0;
		this.enabled = false;
		ActiveWorld();
		playerOverW.SetActive(true);
		LevelUp.SetActive(false);
		
	}
	void ActiveWorld(){
		if(mw.currentWorld == "Overworld"){
			overworld.SetActive(true);
		}else if(mw.currentWorld == "Dungeon"){
			dungeon.SetActive(true);
		}
	}
}
