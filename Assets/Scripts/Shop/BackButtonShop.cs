using UnityEngine;
using System.Collections;

public class BackButtonShop : MonoBehaviour {
	public GameObject buybutton;
	public GameObject sellbutton;
	public GameObject buylist;
	public GameObject sellList;
	public GameObject shop;
	public MovementWorld mw;
	public GameObject playerOW;
	public bool BuySell = false;
	public GameObject overworld;
	public GameObject dungeon;
	void OnMouseEnter(){
		this.guiTexture.color = Color.magenta;
	}
	void OnMouseExit(){
		this.guiTexture.color = Color.gray;
	}
	void OnMouseDown(){
		if(BuySell){
			GameObject[]texts =  GameObject.FindGameObjectsWithTag("BuySellText");
			foreach(GameObject go in texts){
				Destroy(go);
			}
			buybutton.SetActive(true);
			sellbutton.SetActive(true);
			buylist.SetActive(false);
			sellList.SetActive(false);
			BuySell = false;
		}else{
			ActiveWorld();
			playerOW.SetActive(true);
			shop.SetActive(false);
		}
	}
	void ActiveWorld(){
		if(mw.currentWorld == "Overworld"){
			overworld.SetActive(true);
		}else if(mw.currentWorld == "Dungeon"){
			dungeon.SetActive(true);
		}
	}
}
