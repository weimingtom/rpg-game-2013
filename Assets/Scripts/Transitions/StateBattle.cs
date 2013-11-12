using UnityEngine;
using System.Collections;

public class StateBattle : MonoBehaviour {

	public BattleSMachine bMachine;
	public string name;

	
	void Start () {
		bMachine = GetComponent<BattleSMachine>();
	}
	
	
	void Update () {
	
	}

	
	virtual public void OnEnterState(){}
	
	virtual public void OnExitState(){}
}
