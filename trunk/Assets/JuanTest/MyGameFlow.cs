using UnityEngine;
using System.Collections;

public class MyGameFlowFight : MonoBehaviour {
	
	
	
	public ScreenManager sm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//termine de pelear
		if (false /* bla evento*/)
		{
			sm.ChangeScreen(HardcodedScreenNames.SCREEN_LEVELUP);
		}
		
	}
}
