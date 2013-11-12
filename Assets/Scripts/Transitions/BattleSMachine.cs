using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleSMachine : MonoBehaviour {
	
	StateBattle prevState;
	
	
	void Awake () {
		List <StateBattle> states = new List<StateBattle>();
		StateBattle[] sts = GetComponents<StateBattle>();
		
		foreach(StateBattle s in sts){
			if(s.enabled){
				if(prevState != null){
					Debug.Log("There's more than one default state.");
				}
				else{
					prevState = s;
				}
			}
		}
	}
	

	void Update () {
	}
	
	public void ChangeState(string state){
		StateBattle nextState = GetComponent(state) as StateBattle;
		if(nextState != null){
			prevState.OnExitState();
			nextState.OnEnterState();
			nextState.enabled = true;
			prevState.enabled = false;
			prevState = nextState;
		}
	}
}
