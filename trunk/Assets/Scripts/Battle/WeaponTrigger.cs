using UnityEngine;
using System.Collections;

public class WeaponTrigger : MonoBehaviour {
	public Weapon weapon;
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("Deal Damage");
		if (collider.tag.Equals("Enemy"))
		{
			if (weapon.attack)
			{
				//ClaseQueControlaHP cqchp = collider.GetComponent<ClaseQueControlaHP>()
				Enemy en = collider.GetComponent<Enemy>();
				en.hitted = true;
				en.Damaged();
				//cqchp.DealDamage(weaponDamage);
			}
		}
	}
}
