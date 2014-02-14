using UnityEngine;
using System.Collections;

public class SaveButton : MonoBehaviour {
	
	public Transform player;
	public GameObject save;
	public GUIText saveText;
	public Inventory inventory;


	void Start(){
		save = GameObject.FindWithTag("SaveLoad");
	}


	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}


	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}


	void OnMouseDown(){
		TestGameSave tgs = save.GetComponent(typeof(TestGameSave)) as TestGameSave;
		tgs.SaveGame(player);
		ES2.Save(inventory.itemList, "Inventory");
		saveText.text = "The game was saved!";
	}
}
