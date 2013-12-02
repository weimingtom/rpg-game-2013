using UnityEngine;
using System.Collections;

public class OverWordGUI : MonoBehaviour {
	public GUIText statsText;
	GameObject stats;
	
	GameObject player;
	
	void Start () {
		////////////////////////////////////////
		player = GameObject.FindWithTag("PlayerOW");
		stats = GameObject.FindWithTag("Stats");
		//TestGameSave.LoadGame(player.transform);
		////////////////////////////////////////
	}
	
	// Update is called once per frame
	void Update () {
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		statsText.text = "HP: " + cs.hp +"  MP: " + cs.mp;
	}
}
