using UnityEngine;
using System.Collections;

public class OverWordGUI : MonoBehaviour {
	public GUIText statsText;
	public GameObject stats;
	
	GameObject player;
	
	void Start () {
		////////////////////////////////////////
		player = GameObject.FindWithTag("Player");
		TestGameSave.LoadGame(player.transform);
		////////////////////////////////////////
	}
	
	// Update is called once per frame
	void Update () {
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		statsText.text = "HP: " + cs.hp +"  MP: " + cs.mp;
	}
}
