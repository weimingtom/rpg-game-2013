using UnityEngine;
using System.Collections;

public class EnemyAttack : State {

	GameObject player;

	public Transform w1;
	public Transform w2;
	
	float attTime = 0;
	int attCount = 2;
	public float timeBetwAtts = 2f;
	
	bool hit;


	void Awake () {
		w1.animation.Stop();
		w2.animation.Stop();
	}


	void Start () {
		player = GameObject.FindWithTag("Player");
		w1.animation.Stop();
		w2.animation.Stop();
	}
	
	
	void Update () {
		if(timeBetwAtts < 0){
			if(trigger.Found()){
				OnEnterState ();
				timeBetwAtts = 2f;
			}
			else{
				eMachine.ChangeState("EnemyWalk");
			}
		}
		else{
			OnExitState();
			timeBetwAtts -= Time.deltaTime;
		}

		Debug.Log(trigger.Found());
		/*if(trigger.Found()){
			if(attTime > timeBetwAtts){
				if(attCount > 0){
					OnEnterState();
					Debug.Log("attCount>0");
				}
				else{
					attTime = 0;
					attCount = 2;
					Debug.Log("attCount=0");
				}
			}
			else{
				attTime += Time.deltaTime;
				Debug.Log("Not att");
			}
		}
		else{
			eMachine.ChangeState("EnemyWalk");
		}
		Debug.Log(attCount+"  "+attTime);*/
	}
	
	
	
	public override void OnEnterState(){
		if(!player) return;
		else{
			w1.animation.Play("EnemyW1");
			w2.animation.Play("EnemyW2");
			/*
			MovementBattle mb = player.GetComponent(typeof(MovementBattle)) as MovementBattle;
			gameObject.renderer.material.color = Color.red;
			mb.CharacterDamage();
			*/
			//attCount--;
		}
	}


	public override void OnExitState(){
		if(!w1.animation.isPlaying)
			w1.animation.Stop();
		if(!w2.animation.isPlaying)
			w2.animation.Stop();
	}
}
