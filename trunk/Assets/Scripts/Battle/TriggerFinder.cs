using UnityEngine;
using System.Collections;

public class TriggerFinder : MonoBehaviour {
	
	public string searchForTag = "Player";
	private GameObject target;


	void OnTriggerEnter(Collider coll)
	{
		if (target!=null) return;
		if(coll.tag.Equals(searchForTag))
		{
			target = coll.gameObject;
		}
	}
	
	void OnTriggerStay(Collider coll)
	{
		if (target!=null) return;
		if(coll.tag.Equals(searchForTag))
		{
			target = coll.gameObject;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.gameObject.Equals(target))
		{
			target = null;
		}
	}
	
	public GameObject Found()
	{
		return target;
	}
}
