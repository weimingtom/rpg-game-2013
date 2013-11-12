using UnityEngine;
using System.Collections;

public class ExitBattle : StateBattle {

	public GameObject overworld;
	//public GameObject battle;
	public GameObject fadeinOut;
	public GameObject playerOverW;
	public GameObject LevelUp;
	
	void Start () {
	
	}
	

	void Update () {
		LevelUp.SetActive(true);
		
		MovementWorld pj = playerOverW.GetComponent(typeof(MovementWorld)) as MovementWorld;
		pj.enabled = true;
		this.enabled = false;
		fadeinOut.renderer.material.mainTexture = null;
		this.gameObject.SetActive(false);
		//battle.gameObject.SetActive(false);
	}
}
