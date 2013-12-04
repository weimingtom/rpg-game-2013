using UnityEngine;
using System.Collections;

public class ShowItemTextBuy : MonoBehaviour {
	public string itemName;
	//public BuyList buylist;

	void Start(){
		//transform.position = startPos;
	}
	void OnMouseEnter(){
		this.guiText.color = Color.red;

	}
	void OnMouseExit(){
		this.guiText.color = Color.white;
	}
	void OnMouseDown(){
		GameObject.FindWithTag("BuyList").GetComponent<BuyList>().Buy(itemName);
	}
}
