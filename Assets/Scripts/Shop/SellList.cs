using UnityEngine;
using System.Collections;

public class SellList : MonoBehaviour {
	public GUIText noitemText;
	public Inventory inventory;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (inventory.itemList.Count == 0) {
			noitemText.text = "No items for sell!";
		}
	}
}
