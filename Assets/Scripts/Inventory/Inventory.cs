using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public string list;
	string buffer = "";
	TextMesh[] text;
	
	ArrayList items = new ArrayList();
	
	void Start () {
		if(!PlayerPrefs.HasKey("Inventory")){
			list = "";
		}
		else{
			PlayerPrefs.GetString("Inventory");
		}
	}
	
	
	void Update () {
		for(int i = 0; i < list.Length; i++){
			if(list[i] == ' '){
				text[i].text = buffer;
				buffer = "";
			}
		}
	}
	
	
	public void SaveInventory(){
		PlayerPrefs.SetString("Inventory", list);
	}
	
	
	public void AddItem(){
		items.Add("item");
	}
	
	
	void UseItem(){
	
	}
}
