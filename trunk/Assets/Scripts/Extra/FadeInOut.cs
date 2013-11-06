using UnityEngine;
using System.Collections;

public class FadeInOut : MonoBehaviour {
	float alphaFadeValue = 0f;
	
	public GameObject bkScreen;
	public float randEncounterTime;
	public GameObject spawner;
	public GameObject battle;
	public GameObject emptyWorld;
	public GameObject playerBattle;
	public BattleController battleController;
	public MovementWorld mw;
	
	void Start(){
		alphaFadeValue = 0;
		bkScreen.renderer.material.color = new Color(0, 0, 0, alphaFadeValue);
		this.enabled = false;
	}
	
	void Update () {
		if(alphaFadeValue < 1){
			alphaFadeValue += Mathf.Clamp01(Time.deltaTime);
			bkScreen.renderer.material.color = new Color(0, 0, 0, alphaFadeValue);
		}
		else{
			alphaFadeValue = 0;
			mw.randEncounterTime = Random.Range(7,15);
			bkScreen.renderer.material.color = new Color(0, 0, 0, alphaFadeValue);
			battle.SetActive(true);
			MovementBattle mb = playerBattle.GetComponent(typeof(MovementBattle)) as MovementBattle;
			mb.escaped = false;
			battleController.CharSpawing(playerBattle,spawner);
			battleController.EnemyGenerator();
			emptyWorld.SetActive(false);
			this.enabled = false;
		}
	}
}
