using UnityEngine;
using System.Collections;

public class PlayerGils : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text= "Gils: "+ GameObject.FindWithTag("Stats").GetComponent<CharactersStat>().Gils;
	}
}
