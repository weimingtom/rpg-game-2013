using UnityEngine;
using System.Collections;

public class LoadGameButton : MonoBehaviour {
	public GameObject saveLoadOJ;
	public Transform player;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		TestGameSave tgs = saveLoadOJ.GetComponent(typeof(TestGameSave)) as TestGameSave;
		tgs.LoadGame(player);
		//TestGameSave.SaveGame(player);
		//Call function
	}
}
