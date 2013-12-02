using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public GameObject overWorld;
	public Transform player;
	
	void Start () {
	
	}
	
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			overWorld.SetActive(true);
			this.gameObject.SetActive(false);
		}
		
		if(Input.GetKeyDown(KeyCode.M)){
			//TestGameSave.SaveGame(player);
		}
		
		if(Input.GetKeyDown(KeyCode.P)){
			PlayerPrefs.DeleteAll();
		}
	}
}
