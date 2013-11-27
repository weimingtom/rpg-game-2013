using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {
	
	public GameObject overWorld;
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
		overWorld.SetActive(true);
		menu.SetActive(false);
	}
}
