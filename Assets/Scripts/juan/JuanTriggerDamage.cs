using UnityEngine;
using System.Collections;

public class JuanTriggerDamage : MonoBehaviour {

	
	public string attackTag = "Default";
	public float weaponDamage = 9000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("Deal Damage");
		if (collider.tag.Equals("Enemy"))
		{
			if (collider.GetComponent<Enemy>())
			{
				//ClaseQueControlaHP cqchp = collider.GetComponent<ClaseQueControlaHP>()
				Enemy en = collider.GetComponent<Enemy>();
				en.Damaged();
				//cqchp.DealDamage(weaponDamage);
			}
		}
	}
}
