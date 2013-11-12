using UnityEngine;
using System.Collections;

public class EnemyWalk : State {

	GameObject player;
	Vector3 dif;
	float speed = 1f;
	float walkTime;
	
	void Start () {
		player = GameObject.FindWithTag("Player");
		walkTime = Random.Range(1.6f, 2.8f);
	}
	
	
	void Update () {
		walkTime -= Time.deltaTime;
		if(player!=null){
			dif = transform.position - player.transform.position;
			if(dif.magnitude > 1.8f || dif.magnitude < -1.8f){
				gameObject.renderer.material.color = Color.cyan;
				OnEnterState();
			}
			else if(walkTime <= 0f){
				walkTime = Random.Range(1.6f, 2.8f);
				eMachine.ChangeState("EnemyAttack");
			}
		}
	}
	
	
	
	public override void OnEnterState(){
		rigidbody.velocity = new Vector3((player.transform.position.x - transform.position.x) * speed, 0f, (player.transform.position.z - transform.position.z) * speed);
	}
	
	public override void OnExitState(){
		
	}
}

