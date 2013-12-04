using UnityEngine;
using System.Collections;

public class SellButton : MonoBehaviour {
	public GameObject sellList;
	public GUITexture buybutton;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		sellList.SetActive (true);
		buybutton.gameObject.SetActive (false);
		this.gameObject.SetActive (false);
	}
}
