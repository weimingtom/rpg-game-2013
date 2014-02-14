using UnityEngine;
using System.Collections;

public class SellList : MonoBehaviour {
	public GUIText noitemText;
	public Inventory inventory;
	GUIText showItem;
	public GUIText textItem;
	public Transform shop;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (inventory.itemList.Count == 0) {
			noitemText.text = "No items for sell!";
		}else{
			noitemText.text = "";
		}
	}
	public void ShowItemsForSell(){
		float offsetNextItem = 0f;
		for(int i = 0; i<inventory.itemList.Count; i++){
			
			showItem = Instantiate(textItem) as GUIText;
			showItem.GetComponent<ShowItemTextSell>().itemName = inventory.itemList[i].name;
			showItem.text = inventory.itemList[i].name +"     "+inventory.itemList[i].GetComponent<Item>().priceSell+" Gils";
			showItem.transform.parent = shop;
			showItem.transform.position += new Vector3(-0.4f, 0.4f-offsetNextItem,0f);
			showItem.transform.rotation = textItem.transform.rotation;
			showItem.transform.localScale = textItem.transform.localScale;
			offsetNextItem += 0.1f;
		}
	}
	public void SellItem(string item){
		for(int i = 0; i<inventory.itemList.Count; i++){
			if(inventory.itemList[i].name == item){
				inventory.itemList[i].GetComponent<QuantityText>().q--;
				GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().Gils += inventory.itemList[i].GetComponent<Item>().priceSell;
				if(inventory.itemList[i].GetComponent<QuantityText>().q<=0){
					inventory.itemList[i].GetComponent<InventoryText>().Remove();
				}
				return;
			}
		}
	}
}
