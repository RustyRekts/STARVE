using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour 
{
	public bool isCanRed;
	public bool isCanBlue;
	public bool isCanGreen;

	void Awake () 
	{
		
	}
	
	void Update () {
		
	}

	void OnMouseOver() 
	{
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			//1
			if (isCanRed == true && Inventory.isTaken1 == false && Inventory.isTaken2 == true) 
			{
				gameObject.SetActive (false);
				Inventory.isCanRed1 = true;
			}

			//1
			if (isCanBlue == true && Inventory.isTaken1 == false && Inventory.isTaken2 == true) 
			{
				gameObject.SetActive (false);
				Inventory.isCanBlue1 = true;
			}

			//1
			if (isCanGreen == true && Inventory.isTaken1 == false && Inventory.isTaken2 == true) 
			{
				gameObject.SetActive (false);
				Inventory.isCanGreen1 = true;
			}

			//2
			if (isCanRed == true && Inventory.isTaken2 == false) 
			{
				gameObject.SetActive (false);
				Inventory.isCanRed2 = true;
			}

			//2
			if (isCanBlue == true && Inventory.isTaken2 == false) 
			{
				gameObject.SetActive (false);
				Inventory.isCanBlue2 = true;
			}

			//2
			if (isCanGreen == true && Inventory.isTaken2 == false) 
			{
				gameObject.SetActive (false);
				Inventory.isCanGreen2 = true;
			}
		}
	}
}
