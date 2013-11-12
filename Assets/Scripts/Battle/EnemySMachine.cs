using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySMachine : MonoBehaviour {
	
	State prevState;
	

	void Awake () {
		List <State> states = new List<State>();
		State[] sts = GetComponents<State>();
		
		foreach(State s in sts){
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
		State nextState = GetComponent(state) as State;
		if(nextState != null){
			prevState.OnExitState();
			nextState.OnEnterState();
			nextState.enabled = true;
			prevState.enabled = false;
			prevState = nextState;
		}
	}
}
