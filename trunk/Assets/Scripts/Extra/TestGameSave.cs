using UnityEngine;
using System.Collections;

public class TestGameSave {
	/*
	 * 	public int hp=230;
	public int mp=100;
	public int att=10;
	public int def=4;
	public int mag=9;
	public int lvl = 1;
	public int exp = 0;
	public int toLvlExp=100;
	public int critical;
	public GUIText charGUI;
	string Status = "Normal";
	int prevToNextLvl;
	*/
	
	public CharactersStat stat;
	
	public static void SaveGame(Transform player){
		CharactersStat stat;
		PlayerPrefs.SetFloat("PlayerPosX"+player.name, player.position.x);	//player.index instead of player.name
		PlayerPrefs.SetFloat("PlayerPosY"+player.name, player.position.y);
		PlayerPrefs.SetFloat("PlayerPosZ"+player.name, player.position.z);
		
		//PlayerPrefs.SetInt("PlayerHP"+player.name, stat.hp);
		//PlayerPrefs.SetInt("PlayerMP"+player.name, stat.mp);
		
	}
	
	
	public static void LoadGame(Transform player){
		if(PlayerPrefs.HasKey("PlayerPosX")){
			player.position = new Vector3(PlayerPrefs.GetFloat("PlayerPosX"), PlayerPrefs.GetFloat("PlayerPosY"), PlayerPrefs.GetFloat("PlayerPosZ"));
		}
		else{
			player.position = new Vector3(130f, 0.5f, 113f);
		}
	}
}
