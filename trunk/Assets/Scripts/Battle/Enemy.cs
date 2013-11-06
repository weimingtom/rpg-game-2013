using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public int lvl = 1;
	public int hp = 100;
	public int att = 6;
	public int def = 5;
	public int giveExp = 50;
	public GameObject stats;
	public TextMesh dmgText;
	int damage;
	float mult;
	float timeText = 1f;
	public GameObject player;
	Vector3 dif;
	float attTime = 0.7f;
	float delayTime = 1.6f;
	bool damaged = false;
	public GameObject battleCtrller;	
	float speed = 0.2f;
	public int gil = 10;
	
	
	void Start () {
		player = GameObject.FindWithTag("Player");
		stats = GameObject.FindWithTag("Stats");
		battleCtrller = GameObject.FindWithTag("BattleController");
		gameObject.renderer.material.color = Color.cyan;
		attTime = 0f;
		delayTime = 0f;
	}
	

	void Update () {
		BattleController bc = battleCtrller.GetComponent(typeof(BattleController)) as BattleController;
		if(player!=null){
			dif = transform.position - player.transform.position;
			MovementBattle mb = player.GetComponent(typeof(MovementBattle)) as MovementBattle;
			if(mb.escaped){//??
				Destroy(gameObject);
			}
		}
		if(hp <= 0){
			bc.numEnemies--;
			Destroy(gameObject);
		}
		if(damaged){
			timeText -= Time.deltaTime;
			if(timeText<=0){
				dmgText.text="";
				damaged = false;
				timeText = 1f;
			}
		}
		/*if(moveT > 0f){
		else if(attT > 0){
			attT -= Time.deltaTime;
			gameObject.renderer.material.color = Color.red;
		}
		else{
			gameObject.renderer.material.color = Color.cyan;
			moveT = 2f;
			attT = 0.7f;
		}*/
	}
	
	
	public void Damaged(){
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		damage = (cs.att - def) * Random.Range(7, 14);
		dmgText.text = damage.ToString();
		hp -= damage;
		damaged = true;
	}
}
