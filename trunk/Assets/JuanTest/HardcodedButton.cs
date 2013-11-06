using UnityEngine;
using System.Collections;

public class HardcodedButton : MonoBehaviour {
	
	public ScreenManager sm;
	
	void OnMouseDown()
	{
		sm.ChangeScreen(HardcodedScreenNames.SCREEN_OVERWORLD);
	}
	
}
