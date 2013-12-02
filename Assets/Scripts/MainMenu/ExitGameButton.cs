using UnityEngine;
using System.Collections;

public class ExitGameButton : MonoBehaviour {

	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		Application.Quit();
		//TestGameSave.SaveGame(player);
		//Call function
	}
}
