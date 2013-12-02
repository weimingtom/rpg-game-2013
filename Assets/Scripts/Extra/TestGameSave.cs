using UnityEngine;
using System.Collections;

public class TestGameSave : MonoBehaviour {
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
	//public Vector3 playerPos = new Vector3(0,0,0);
	public CharactersStat stat;
	public GameObject mainMenu;
	//public bool saved = false;
	public MovementWorld mw;
	public GameObject overworld;
	public GameObject dungeon;
	public GameObject charGUI;
	public GameObject playerOW;
	public void SaveGame(Transform player){
		/*CharactersStat stat;
		MovementWorld mw;*/
		PlayerPrefs.SetFloat("PlayerPosX", player.position.x);	//player.index instead of player.name
		PlayerPrefs.SetFloat("PlayerPosY", player.position.y);
		PlayerPrefs.SetFloat("PlayerPosZ", player.position.z);
		
		PlayerPrefs.SetInt("PlayerHP", stat.hp);
		PlayerPrefs.SetInt("PlayerMAXHP", stat.maxHP);
		PlayerPrefs.SetInt("PlayerMP", stat.mp);
		PlayerPrefs.SetInt("PlayerMAXMP", stat.maxMP);
		PlayerPrefs.SetInt("PlayerATT", stat.att);
		PlayerPrefs.SetInt("PlayerDEF", stat.def);
		PlayerPrefs.SetInt("PlayerMAG", stat.mag);
		PlayerPrefs.SetInt("PlayerLVL", stat.lvl);
		PlayerPrefs.SetInt("PlayerEXP", stat.exp);
		PlayerPrefs.SetInt("PlayerGILS", stat.Gils);
		PlayerPrefs.SetInt("PlayerLVLEXP", stat.toLvlExp);
		PlayerPrefs.SetString("PlayerCURRW", mw.currentWorld);
		//saved = true;
	}
	
	
	public void LoadGame(Transform player){

		/*CharactersStat stat;
		MovementWorld mw;*/
		if(PlayerPrefs.HasKey("PlayerPosX")){
			Debug.Log("LoadedGame");
			player.position = new Vector3(PlayerPrefs.GetFloat("PlayerPosX"), PlayerPrefs.GetFloat("PlayerPosY"), PlayerPrefs.GetFloat("PlayerPosZ"));
			stat.hp = PlayerPrefs.GetInt("PlayerHP");
			stat.maxHP = PlayerPrefs.GetInt("PlayerMAXHP");
			stat.mp = PlayerPrefs.GetInt("PlayerMP");
			stat.maxMP = PlayerPrefs.GetInt("PlayerMAXMP");
			stat.att = PlayerPrefs.GetInt("PlayerATT");
			stat.def = PlayerPrefs.GetInt("PlayerDEF");
			stat.mag = PlayerPrefs.GetInt("PlayerMAG");
			stat.lvl = PlayerPrefs.GetInt("PlayerLVL");
			stat.exp = PlayerPrefs.GetInt("PlayerEXP");
			stat.Gils = PlayerPrefs.GetInt("PlayerGILS");
			stat.toLvlExp = PlayerPrefs.GetInt("PlayerLVLEXP");
			mw.currentWorld= PlayerPrefs.GetString("PlayerCURRW");
		}
		else{
			Debug.Log("NoLoaded");
			player.position = new Vector3(130f, 0.5f, 113f);
		}
		mainMenu.SetActive(false);
		ActiveWorld();
		charGUI.SetActive(true);
		playerOW.SetActive(true);
	}
	public void NewGame(){
		PlayerPrefs.DeleteAll();
		playerOW.transform.position = new Vector3(130f, 0.5f, 113f);
		mainMenu.SetActive(false);
		ActiveWorld();
		charGUI.SetActive(true);
		playerOW.SetActive(true);
	}
	void ActiveWorld(){
		if(mw.currentWorld == "Overworld"){
			overworld.SetActive(true);
		}else if(mw.currentWorld=="Dungeon"){
			dungeon.SetActive(true);
		}
	}
}
