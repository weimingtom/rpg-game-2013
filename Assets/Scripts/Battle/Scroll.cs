using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	
	public GameObject overworld;
	public GameObject battle;
	public GameObject fadeinOut;
	
	
	void Start () {
		
		//this.renderer.material.color = new Color(0, 0, 0, alphaFadeValue);
	}
	
	
	public void ShowScroll(){
		Debug.Log("IN");
		
		/*if(Input.GetKey(KeyCode.L)){
			overworld.SetActive(true);
			this.gameObject.SetActive(false);
			fadeinOut.renderer.material.mainTexture = null;
			battle.gameObject.SetActive(false);
		}*/
	}
	
	public void OutScroll(){
		overworld.SetActive(true);
		this.gameObject.SetActive(false);
		fadeinOut.renderer.material.mainTexture = null;
		battle.gameObject.SetActive(false);
	}
}
