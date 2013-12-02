using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {
	public DungeonManager dm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag.Equals("PlayerOW")){
			coll.gameObject.transform.position = dm.gotoLadder.transform.position + new Vector3(3,0,0);
			if(dm.floorNumber == "Floor 1"){
				dm.floorNumber = "Floor S1";
			}else if(dm.floorNumber == "Floor S1"){
				dm.floorNumber = "Floor 1";
			}
		}
	}
}
