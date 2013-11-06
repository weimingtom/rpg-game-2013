using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {
	
	
	public GameObject[] screens;
	public int currentScreen = 0;
	
	
	void Start()
	{
		ChangeScreen(currentScreen);
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			currentScreen++;
			if (currentScreen>=screens.Length) currentScreen = 0;
			ChangeScreen(currentScreen);
		}
	}
	
	public void ChangeScreen(int index)
	{
		if(index<0 || index >= screens.Length) return;
		
		TurnOffAll();
		
		screens[index].SetActive(true);
		currentScreen = index;
	}
	
	private void TurnOffAll()
	{
		foreach (GameObject go in screens)
		{
			go.SetActive(false);
		}
	}
}
