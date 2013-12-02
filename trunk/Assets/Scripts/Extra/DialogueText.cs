using UnityEngine;
using System.Collections;

public class DialogueText : MonoBehaviour {
	public GUIText thisText;
	float textTimer = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(thisText.text != ""){
			textTimer -= Time.deltaTime;
			if(textTimer <=0){
				thisText.text = "";
				textTimer = 2f;
			}
		}
	}
}
