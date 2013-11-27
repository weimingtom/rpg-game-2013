using UnityEngine;
using System.Collections;

public class SaveButton : MonoBehaviour {
	
	public Transform player;
	
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		TestGameSave.SaveGame(player);
		//Call function
	}
}
