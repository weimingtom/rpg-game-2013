using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public int lvl = 1;
	public int hp = 100;
	public int att;
	public int def;
	public int giveExp = 50;
	public GameObject stats;
	public TextMesh dmgText;
	int damage;
	float mult;
	float timeText = 1f;
	public GameObject player;
	bool damaged = false;
	public GameObject battleCtrller;
	public int gil = 10;
	public bool hitted = false;
	public bool CanBeHit = true;
	float timeHitted = 6f;
	
	
	void Start () {
		player = GameObject.FindWithTag("Player");
		stats = GameObject.FindWithTag("Stats");
		battleCtrller = GameObject.FindWithTag("BattleController");
		gameObject.renderer.material.color = Color.cyan;
	}
	

	void Update () {
		BattleController bc = battleCtrller.GetComponent(typeof(BattleController)) as BattleController;
		if(player != null){
			MovementBattle mb = player.GetComponent(typeof(MovementBattle)) as MovementBattle;
			if(mb.escaped){
				Destroy(gameObject);
			}
		}
		if(hp <= 0){
			bc.numEnemies--;
			Destroy(gameObject);
		}
		if(damaged){
			timeText -= Time.deltaTime;
			if(timeText <= 0){
				dmgText.text = "";
				damaged = false;
				timeText = 1f;
			}
		}
		if(hitted){
			CanBeHit = false;
			timeHitted -= Time.deltaTime;
			if(timeHitted <= 0 ){
				timeHitted = 6f;
				hitted = false;
				CanBeHit = true;
			}
		}
	}
	
	
	public void Damaged(){
		if(CanBeHit){
			CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
			damage = (cs.att - def) * Random.Range(7, 14);
			dmgText.text = damage.ToString();
			dmgText.gameObject.isStatic = true;
			hp -= damage;
			damaged = true;
		}
	}
}
