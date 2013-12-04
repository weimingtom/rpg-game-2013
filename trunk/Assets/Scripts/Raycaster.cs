using UnityEngine;
using System.Collections;

public class Raycaster : MonoBehaviour {
	
	Camera cam;
	public Inventory inventory;

	void Start () {
		cam = this.camera;
	}
	

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.tag == "Item"){
					for(int i = 0; i<inventory.itemList.Count; i++){
						if(inventory.itemList[i] == hit.transform.gameObject)
							inventory.UseItem(i);
					}
				}
			}
		}
	}
}
