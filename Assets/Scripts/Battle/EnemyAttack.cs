using UnityEngine;
using System.Collections;

public class EnemyAttack : State {

	GameObject player;
	Vector3 dif;
	float attTime;
	int attCount = 1;
	
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	
	void Update () {
		attTime -= Time.deltaTime;
		if((attCount <= 0) || (dif.magnitude > 1.8f || dif.magnitude < -1.8f)){
			attCount = 1;
			eMachine.ChangeState("EnemyWalk");
		}
		else if(attTime <= 0){
				attTime = 1.0f;
				OnEnterState();
		}
	}
	
	
	
	public override void OnEnterState(){
		if(player != null){
			MovementBattle mb = player.GetComponent(typeof(MovementBattle)) as MovementBattle;
			gameObject.renderer.material.color = Color.red;
			mb.CharacterDamage();
			attCount--;
		}
	}
	
	public override void OnExitState(){
		
	}
}
