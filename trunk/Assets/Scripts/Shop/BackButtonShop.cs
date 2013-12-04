using UnityEngine;
using System.Collections;

public class BackButtonShop : MonoBehaviour {
	public GameObject buybutton;
	public GameObject sellbutton;
	public GameObject buylist;
	public GameObject sellList;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){

	}
}
