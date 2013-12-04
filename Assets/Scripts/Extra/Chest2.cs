using UnityEngine;
using System.Collections;

public class Chest2 : MonoBehaviour {
	public bool opened = false;
	public GameObject itemInChest;
	public GameObject chestChild;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(opened){
			chestChild.renderer.material.color = Color.red;
		}
	}
}
