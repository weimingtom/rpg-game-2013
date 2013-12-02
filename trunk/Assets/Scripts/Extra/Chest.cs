using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {
	public bool opened = false;
	public int gilsInChest = 0;
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
