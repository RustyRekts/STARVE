using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeStats : MonoBehaviour {

	private bool dropHealth = false;

	public GameObject red;

	public Text HpText;
	private float Health = 100;

	public Text HungerText;
	private float Hunger = 100;

	public Text H20Text;
	private float H20 = 100;

	void Start () {
		red.SetActive (false);
		StartCoroutine (decrease ());
	}

	void Update () {
		HpText.text = "Health:" + Health;
		HungerText.text = "Hunger:" + Hunger;
		H20Text.text = "H2O:" + H20;

		if (H20 <= 0) {
			H20Text.text = "H20: 0";
		}
		if (Hunger <= 0) 
		{
			HungerText.text = "Hunger: 0";
		}

		if (Hunger <= 0 && H20 <= 0) {
			dropHealth = true;
		}
		if (Health <= 99) 
		{
			red.SetActive (true);
		}
		if (Health <= 0) 
		{
			HpText.text = "Health: 0";
		}
	}

	IEnumerator decrease () {
		if (dropHealth == true) 
		{
			yield return new WaitForSeconds (2);
			Health -= 1;
		}
		if (H20 <= 0) 
		{
			yield return new WaitForSeconds (3);
			Hunger -= 1;
		}
		if (Hunger <= 0) 
		{
			yield return new WaitForSeconds (3);
			H20 -= 1;
		}
		yield return new WaitForSeconds (6);
		H20 -= 2;
		Hunger -= 1;
		StartCoroutine (decrease ());
	}
}
