using UnityEngine;
using System.Collections;

public class ShowItemTextSell : MonoBehaviour {
	public string itemName;
	void Update(){
		if(GameObject.FindWithTag("Inventory").GetComponent<Inventory>().itemList.Count<=0){
			Destroy(this.gameObject);
		}
	}
	void OnMouseEnter(){
		this.guiText.color = Color.red;
		
	}
	void OnMouseExit(){
		this.guiText.color = Color.white;
	}
	void OnMouseDown(){
		GameObject.FindWithTag("SellList").GetComponent<SellList>().SellItem(itemName);
	}
}
