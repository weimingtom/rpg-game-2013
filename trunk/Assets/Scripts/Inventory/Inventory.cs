using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> itemList;
	
	Vector3 offset = new Vector3(0f, -0.08f, 0f);
	Vector3 startPos = new Vector3(-0.36f, 0.3f, -0.8f);
	public TextMesh itName;

	public GameObject menu;


	void Start(){
		if(ES2.Exists("Inventory"))
		   ES2.LoadList<GameObject>("Inventory");
		else
			itemList = new List<GameObject>();
	}


	void Update(){
		//ES2.Save(itemList, "Invertory"); // Move!!
	}
	



	public void AddItem(GameObject item){
		for(int i = 0; i < itemList.Count; i++){
			if(itemList[i].name == item.name){
				itemList[i].GetComponent<QuantityText>().q++;
				itemList[i].GetComponent<InventoryText>().Add();
				return;
			}
		}
		
		TextMesh newItem;
		newItem = Instantiate(itName) as TextMesh;
		newItem.transform.parent = menu.transform;
		newItem.transform.rotation = itName.transform.rotation;
		newItem.transform.localScale = itName.transform.localScale;
		
		if(itemList.Count == 0){
			newItem.transform.localPosition = startPos;
		}
		else{
			newItem.transform.localPosition = itemList[itemList.Count-1].transform.position + offset;
		}

		itemList.Add(newItem.gameObject);
		itemList[itemList.Count-1].GetComponent<QuantityText>().q = 1;
		itemList[itemList.Count-1].AddComponent(item.name);
		itemList[itemList.Count-1].GetComponent<Item>().priceBuy = item.GetComponent<Item>().priceBuy;
		itemList[itemList.Count-1].GetComponent<Item>().priceSell = item.GetComponent<Item>().priceSell;
		newItem.GetComponent<InventoryText>().SetItem(item, itemList.Count-1);
			
	}
	



	public void UseItem(int index){
		itemList[index].GetComponent<Item>().Effect();
		itemList[index].GetComponent<QuantityText>().q--;
		itemList[index].GetComponent<InventoryText>().Remove();
	}


	public void EquipItem(int index){
			for(int i = 0; i < itemList.Count; i++){
				if(itemList[i].GetComponent<Item>().equipable){
					itemList[i].GetComponent<Sword>().Dequip();
					itemList[i].GetComponent<TextMesh>().renderer.material.color = Color.white;
				}
			}
			itemList[index].GetComponent<Sword>().Equip();
			itemList[index].GetComponent<TextMesh>().renderer.material.color = Color.blue;
	}
}
