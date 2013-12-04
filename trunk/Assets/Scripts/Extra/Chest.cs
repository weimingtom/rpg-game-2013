using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {
	public bool opened = false;
	public int gilsInChest = 0;
	public GameObject chestChild;


	void Start () {
	
	}
	


	void Update () {
		if(opened){
			chestChild.renderer.material.color = Color.red;
		}
	}
}
