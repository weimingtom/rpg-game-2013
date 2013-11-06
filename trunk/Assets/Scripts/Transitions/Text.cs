using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Text : StateBattle {
	

	
	public GameObject stats;
	public Texture2D scrollT;
	public bool keyPressed = false;
	public GameObject fadeinOut;
	public Bridge bridge;
	public GUIText winText;
	
	void Start () {
		List<string> Text = new List<string>();
		fadeinOut.renderer.material.mainTexture = scrollT;
	}
	
	
	void Update () {
		winText.text = "Exp Gained: " + bridge.totalExp + "\n Gil: " + bridge.totalGil;
		StartCoroutine(WaitForKeypress3("space"));
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
		//cs.LevelUp();
		/*if(cs.leveledUp){
			Debug.Log("Levelee");
			/*if(Input.GetKeyDown(KeyCode.L)){
				winText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
				if(Input.GetKeyDown(KeyCode.L)){
					bMachine.ChangeState("ExitBattle");
				}
			}
			
			//winText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
			//cs.leveledUp = false;
			StartCoroutine(WaitForKeypress("space"));
		
		}*/
		StartCoroutine(WaitForKeypress2("space"));
			//bMachine.ChangeState("ExitBattle")
	}
	IEnumerator WaitForKeypress(string button){
		
		//while(!keyPressed){
			Debug.Log("IN while");
			//if(Input.GetKeyDown(button)){Debug.Log("IN if");
				CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
				winText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
				cs.leveledUp = false;
				StartCoroutine(WaitForKeypress2("space"));
				//break;
			//}
			
			yield return 0;
		//}
	}
	IEnumerator WaitForKeypress3(string button){
		while(!keyPressed){
			if(Input.GetKeyDown(button)){
				CharactersStat cs = stats.GetComponent(typeof(CharactersStat)) as CharactersStat;
				cs.exp += bridge.totalExp;
				cs.toLvlExp -= bridge.totalExp;
				cs.Gils += bridge.totalGil;
				cs.LevelUp();
				if(cs.leveledUp){
					Debug.Log("Levelee");
					//StartCoroutine(WaitForKeypress("space"));
					winText.text = "You Leveled Up!"+"\n Lvl: "+cs.lvl+"\n HP: "+cs.maxHP+"\n ATK: "+cs.att+"\n DEF: "+cs.def+"\n MP: "+cs.maxMP+"\n MAG: "+cs.mag;
					cs.leveledUp = false;
					yield return StartCoroutine(WaitForKeypress2("space"));
				}
				//break;
			}
			yield return StartCoroutine(WaitForKeypress2("space"));
		}
	}
	IEnumerator WaitForKeypress2(string button){
		while(!keyPressed){
			if(Input.GetKeyDown(button)){
				winText.text="";
				bridge.totalExp = 0;
				bridge.totalGil = 0;
				keyPressed = true;
				bMachine.ChangeState("ExitBattle");
				break;
			}
			yield return 0;
		}
	}
}
