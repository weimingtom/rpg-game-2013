using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {
	
	public GameObject overworld;
	public GameObject dungeon;
	public GameObject playerOW;
	public MovementWorld mw;
	public GameObject menu;
	public GUIText statsText;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		statsText.text = "";
		ActiveWorld();
		playerOW.SetActive(true);
		menu.SetActive(false);
	}
	void ActiveWorld(){
		if(mw.currentWorld == "Overworld"){
			overworld.SetActive(true);
		}else if(mw.currentWorld == "Dungeon"){
			dungeon.SetActive(true);
		}
	}
}
