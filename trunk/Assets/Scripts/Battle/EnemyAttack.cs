using UnityEngine;
using System.Collections;

public class EnemyAttack : State {

	GameObject player;

	public Transform w1;
	public Transform w2;
	

	public string nextState;
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
				eMachine.ChangeState(nextState);
			}
		}
		else{
			OnExitState();
			timeBetwAtts -= Time.deltaTime;
		}
	}
	
	
	
	public override void OnEnterState(){
		if(!player) return;
		else{
			w1.animation.Play("EnemyW1");
			w2.animation.Play("EnemyW2");
		}
	}


	public override void OnExitState(){
		if(!w1.animation.isPlaying)
			w1.animation.Stop();
		if(!w2.animation.isPlaying)
			w2.animation.Stop();
	}
}
