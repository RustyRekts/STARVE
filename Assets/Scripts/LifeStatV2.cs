using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeStatV2 : MonoBehaviour {

	private bool dropHealth;
	public GameObject hurt;

	public Slider healthSlider;
	public static float health;

	public Slider waterSlider;
	public static float water;

	public Slider hungerSlider;
	public static float hunger;

	void Start () {
		hurt.SetActive (false);
		StartCoroutine (decrease ());
		health = 100;
		water = 100;
		hunger = 100;
	}

	void Update () {
		healthSlider.value = health;
		waterSlider.value = water;
		hungerSlider.value = hunger;

		if (water >= 100) 
		{
			waterSlider.value = 100;
		}
		if (hunger >= 100) 
		{
			hungerSlider.value = 100;
		}
		if (health >= 100) 
		{
			healthSlider.value = 100;
		}

		if (hunger <= 0 && water <= 0) {
			dropHealth = true;
		}

		if (health <= 99) 
		{
			hurt.SetActive (true);
		}
		if (health >= 99) 
		{
			hurt.SetActive (false);
		}

		if (water >= 70 && hunger >= 70) {
			dropHealth = false;
			health += 0.1f;
		}
	}

	IEnumerator decrease () 
	{
		if (dropHealth == true) 
		{
			yield return new WaitForSeconds (2);
			health -= 1;
		}
		if (water <= 0) 
		{
			yield return new WaitForSeconds (3);
			hunger -= 1;
		}
		if (hunger <= 0) 
		{
			yield return new WaitForSeconds (3);
			water -= 1;
		}
		yield return new WaitForSeconds (6);
		water -= 2;
		hunger -= 1;
		StartCoroutine (decrease ());
	}
}
