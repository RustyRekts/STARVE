using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2 : MonoBehaviour {

    public AudioSource audioSource;
    public float howMuchToAdd;
	public bool water;
	public bool hunger;
	public bool health;

	void Start () {
        
    }

	void Update () {
		
	}

	void OnMouseOver()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			if (water == true) 
			{
                audioSource.Play();
                LifeStatV2.water += howMuchToAdd;
				gameObject.SetActive (false);
			}
			if (hunger == true) 
			{
                audioSource.Play();
                LifeStatV2.hunger += howMuchToAdd;
				gameObject.SetActive (false);
			}
			if (health == true) 
			{
                audioSource.Play();
                LifeStatV2.health += howMuchToAdd;
				gameObject.SetActive (false);
			}
		}
	}
}