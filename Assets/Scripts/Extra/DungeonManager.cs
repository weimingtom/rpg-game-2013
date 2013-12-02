using UnityEngine;
using System.Collections;

public class DungeonManager : MonoBehaviour {
	public GameObject[] ladders;
	public GameObject gotoLadder;
	public string floorNumber = "Floor 1";
	public GUIText floorText;
	// Use this for initialization
	void Start () {
		gotoLadder = ladders[1];
	}
	
	// Update is called once per frame
	void Update () {
		if(floorNumber == "Floor 1"){
			gotoLadder = ladders[1];
		}else if(floorNumber == "Floor S1"){
			gotoLadder = ladders[0];
		}
		floorText.text = floorNumber;
	}
}
