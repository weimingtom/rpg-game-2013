using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryText : MonoBehaviour {

	public TextMesh textName;
	public TextMesh textQuantity;

	int index;
	int v;
	
	void Start () {
	}
	
	
	public void SetItem(GameObject item, int i){
		textName.gameObject.name = item.name;
		textName.text = item.name;
		textName.tag = "Item";
		index = i;
		v = gameObject.GetComponent<QuantityText>().q;
		textQuantity.text = "x" + v.ToString("00");
	}
	
	
	public void Add(){
		v = gameObject.GetComponent<QuantityText>().q;
		textQuantity.text = "x" + v.ToString("00");
	}


	public void Remove(){print ("Q"+gameObject.GetComponent<QuantityText>().q);
		v = gameObject.GetComponent<QuantityText>().q;
		print ("V"+v);
		if(v > 0)
			textQuantity.text = "x" + v.ToString("00");
		else
			RemoveText();
	}


	void RemoveText(){
		GameObject.FindWithTag("Inventory").GetComponent<Inventory>().itemList.RemoveAt(index);
		Destroy(gameObject);
	}
}
