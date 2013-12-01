using UnityEngine;
using System.Collections;

public class State : MonoBehaviour {

	public EnemySMachine eMachine;
	public string name;
	
	public TriggerFinder trigger;

	
	void Start () {
		eMachine = GetComponent<EnemySMachine>();
	}
	
	
	void Update () {
	
	}

	
	virtual public void OnEnterState(){}
	
	virtual public void OnExitState(){}
}
