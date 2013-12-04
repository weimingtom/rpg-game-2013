using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public  int priceBuy;
	public  int priceSell;
	[System.NonSerialized]
	public  int cant=1;
	public virtual void Effect(){}
}
