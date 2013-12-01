using UnityEngine;
using System.Collections;

public class EnemyWalk : State {

	GameObject player;
	Vector3 dif;
	float speed = 4.8f;
	float rotateTime;

	Quaternion rot;
	
	
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	
	void Update () {
		if(player != null){
			dif = player.transform.position - transform.position;
			rot = transform.rotation;
			transform.LookAt(player.transform);

			if(Quaternion.Angle(rot, transform.rotation) > 0.3f){
				Rotate();
			}
			else{
				Walk();
			}

			if(trigger.Found()){
				eMachine.ChangeState("EnemyAttack");
			}
		}
	}


	void Rotate(){
		transform.rotation = Quaternion.Lerp(rot, transform.rotation, 3f * Time.deltaTime);
		rigidbody.velocity = transform.forward*(speed/2);
	}

	void Walk(){
		rigidbody.velocity = transform.forward*speed;
	}
	
	
	
	public override void OnEnterState(){
	}
	
	public override void OnExitState(){
		
	}
}

