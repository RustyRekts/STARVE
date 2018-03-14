using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {


    private bool i1;
    private bool i2;
    private bool i3;
    private bool i4;

    // Use this for initialization
    void Start () {
        i1 = true;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

	void OnMouseOver () 
	{
        if (Input.GetKeyDown(KeyCode.E) && i1 == true) 
		{
            gameObject.SetActive(false);
            Inventory.inv1Much += 1;

            if (Inventory.inv1Much >= 10)
            {
                i2 = true;
                i1 = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && i2 == true)
        {
            gameObject.SetActive(false);
            if (Inventory.inv2Much >= 0)
            {
                Inventory.inv2Much += 1;
            }
            if (Inventory.inv2Much >= 10)
            {
                i3 = true;
                i2 = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && i3 == true)
        {
            gameObject.SetActive(false);
            Inventory.inv3Much += 1;

            if (Inventory.inv3Much >= 10)
            {
                i4 = true;
                i3 = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && i4 == true)
        {
            gameObject.SetActive(false);
            Inventory.inv4Much += 1;

            if (Inventory.inv4Much >= 10)
            {
                i4 = false;
            }
        }
    }
}