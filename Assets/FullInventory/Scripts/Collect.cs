using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour {

	public Text collect1;

	void Start () 
	{
		collect1.text = "1 RED CAN";
	}

	void Update () 
	{
		if (Inventory.redCanHas == true) 
		{
			collect1.text = "1 GREEN CAN";

			if (Inventory.greenCanHas == true) 
			{
				collect1.text = "1 BLUE CAN";

				if (Inventory.blueCanHas == true) 
				{
					collect1.text = "U DID IT!";
				}
			}
		}
	}
}