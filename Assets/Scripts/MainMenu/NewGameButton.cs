using UnityEngine;
using System.Collections;

public class NewGameButton : MonoBehaviour {
	public GameObject saveLoadOJ;
	
	
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	
	void OnMouseDown(){
		TestGameSave tgs = saveLoadOJ.GetComponent(typeof(TestGameSave)) as TestGameSave;
		tgs.NewGame();
		ES2.Delete("Inventory");
		//TestGameSave.SaveGame(player);
		//Call function
	}
}
