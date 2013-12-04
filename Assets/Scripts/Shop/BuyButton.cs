using UnityEngine;
using System.Collections;

public class BuyButton : MonoBehaviour {
	public GameObject buyList;
	public GUITexture sellbutton;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		buyList.SetActive (true);
		buyList.GetComponent<BuyList>().ShowList();
		sellbutton.gameObject.SetActive (false);
		this.gameObject.SetActive (false);
	}
}
