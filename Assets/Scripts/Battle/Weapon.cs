using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public Transform gotoRot; 
	public bool attack = false;
	private Quaternion originalRot;
	public float easing = 3;
	
/*	
	void Start () {
		originalRot = transform.localRotation;
	}
	
	
	void FixedUpdate () 
	{
		if (attack)
		{
			transform.localRotation = Quaternion.Lerp(transform.localRotation, gotoRot.localRotation, Time.deltaTime*easing);
			if (Quaternion.Angle(transform.localRotation, gotoRot.localRotation)< 1)
			{
				attack = false;
			}
		}
		else
		{
			transform.localRotation = Quaternion.Lerp(transform.localRotation, originalRot, Time.deltaTime*easing);
		}
	}
	
	public void Attack()
	{
		attack = true;
	}*/
}
