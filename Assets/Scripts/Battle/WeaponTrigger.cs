using UnityEngine;
using System.Collections;

public class WeaponTrigger : MonoBehaviour {

	public MovementBattle c;
	
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("Deal Damage");
		if (collider.tag.Equals("Enemy"))
		{
			if (c.attacking)
			{
				Enemy en = collider.GetComponent<Enemy>();
				en.hitted = true;
				en.Damaged();
				c.attacking = false;
			}
		}
	}
}
