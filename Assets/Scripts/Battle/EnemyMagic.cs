using UnityEngine;
using System.Collections;

public class EnemyMagic : State {

	float delay = 3f;
	float timer;
	bool cast = false;

	public string nextState;

	public ParticleSystem particle;

	Transform player;


	void Start() {
		player = GameObject.FindWithTag("Player").transform;
	}
	

	void Update () {
		if(timer <= 0f){
			cast = true;
			timer = delay;
		}
		else{
			timer -= Time.deltaTime;
		}
	}



	void OnTriggerStay(Collider coll){
		if(coll.tag.Equals("Player")){
			if(cast){
				Instantiate(particle, coll.transform.position, Quaternion.identity);
				cast = false;
			}
		}
	}


	void OnTriggerExit(Collider coll){
		if(coll.tag.Equals("Player")){
			eMachine.ChangeState("EnemyWalk");
		}
	}


	public override void OnEnterState(){
		timer = delay;
	}
	
	public override void OnExitState(){
		
	}
}
