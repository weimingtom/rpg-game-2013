using UnityEngine;
using System.Collections;

public class BattleController : StateBattle {
	
	public GameObject stats;
	public GameObject[] nParty;
	public GUIText statsText;
	GameObject party;
	//public int totalExp;
	public int numEnemies;
	public Scroll scroll;
	public GameObject player;
	public GameObject weapon;
	public Text stateText;
	//public GUIText winText;
	//public int totalGil;
	public GameObject LevelUp;
	public Bridge bridge;
	public GameObject playerOW;
	public GameObject outFloor;
	public Material mat1;
	public Material mat2;
	
	public void EnemyGenerator(){
		int numEnemy = Random.Range(3,6);
		for(int i= 0; i<numEnemy; i++){
			party = Instantiate(nParty[Random.Range(0, nParty.Length)]) as GameObject;
			numEnemies ++;
			Enemy en = party.GetComponent(typeof(Enemy)) as Enemy;
			bridge.totalExp += en.giveExp;
			bridge.totalGil+= en.gil;
		}
	}
	
	public void CharSpawing(GameObject player, GameObject SpawnPoint){
		player.transform.position = SpawnPoint.transform.position;
	}
	
	public void DestroyParty(){
		Destroy(party);
	}
	
	public void CheckEnemies(){
		if(numEnemies <= 0){
			CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
			player.SetActive(false);
			weapon.SetActive(false);
			cs.exp += bridge.totalExp;
			cs.toLvlExp -= bridge.totalExp;
			cs.Gils += bridge.totalGil;
			cs.LevelUp();
			LevelUp.SetActive(true);
			this.gameObject.SetActive(false);
			//scroll.ShowScroll();
			
			/*
			CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
			cs.exp += totalExp;
			cs.toLvlExp -= totalExp;
			cs.Gils += totalGil;
			winText.text = "Exp Gained: " + totalExp + "\n Gil: " + totalGil;
			cs.LevelUp();
			if(cs.leveledUp){
				if(Input.GetKeyDown(KeyCode.L)){
					winText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
					if(Input.GetKey(KeyCode.L)){
						scroll.OutScroll();
					}
				}
				cs.leveledUp = false;
			}else{
				winText.text="";
				totalExp = 0;
				totalGil = 0;
				scroll.OutScroll();
			}
			*/
			
			
			/*
			overWorld.SetActive(true);
			this.gameObject.SetActive(false);*/
		}
	}
	void Start(){
		stats = GameObject.FindWithTag("Stats");
	}
	
	void OnGUI(){
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		statsText.text = "HP: "+cs.hp+"  "+"MP: "+cs.mp;
	}
	void Update(){
		MovementWorld mw = playerOW.GetComponent(typeof(MovementWorld)) as MovementWorld;
		if(mw.currentWorld == "Overworld"){
			outFloor.renderer.material = mat1;
		}else if(mw.currentWorld == "Dungeon"){
			outFloor.renderer.material = mat2;
		}
	}
}
