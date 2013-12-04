using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuyList : MonoBehaviour {
	public GUIText textItem;
	public GUIText noMoney;
	public Transform shop;
	public List<GameObject> buyList = new List<GameObject>();
	GUIText showItem;
	public Inventory inventory;
	public GUIText gils;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		gils.text = "Gils: "+ GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().Gils;
	}
	public void ShowList(){
		float offsetNextItem = 0f;
		for(int i = 0; i<buyList.Count; i++){

			showItem = Instantiate(textItem) as GUIText;
			showItem.GetComponent<ShowItemTextBuy>().itemName = buyList[i].name;
			showItem.text = buyList[i].name +"     "+buyList[i].GetComponent<Item>().priceBuy+" Gils";
			showItem.transform.parent = shop;
			showItem.transform.position += new Vector3(-0.4f, 0.4f-offsetNextItem,0f);
			showItem.transform.rotation = textItem.transform.rotation;
			showItem.transform.localScale = textItem.transform.localScale;
			offsetNextItem += 0.1f;
		}
	}
	public void Buy(string itemName){
		for(int i = 0; i<buyList.Count; i++){
			if(buyList[i].name == itemName){
				if(GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().Gils >= buyList[i].GetComponent<Item>().priceBuy){
					inventory.AddItem(buyList[i]);
					GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().Gils -= buyList[i].GetComponent<Item>().priceBuy;
					noMoney.text = "You bought a " + buyList[i].name;
				}else{
					noMoney.text= "No enough Gils!";
				}
				return;
			}
		}
	}
}
