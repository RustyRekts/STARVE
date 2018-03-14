using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static float wateradd1;
    public static float hungeradd1;
    public static float healthadd1;
    public Text inv1Text;
    public GameObject image1;
    private bool inv1;
    public static float inv1Much;

    public Text inv2Text;
    public GameObject image2;
    private bool inv2;
    public static float inv2Much;

    public Text inv3Text;
    public GameObject image3;
    private bool inv3;
    public static float inv3Much;

    public Text inv4Text;
    public GameObject image4;
    private bool inv4;
    public static float inv4Much;

    void Awake()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        inv1 = true;
    }

    void Update()
    {
        if (inv1Much <= 10 && inv1 == true)
        {
            if (inv1Much >= 1)
            {
                inv1Text.text = "" + inv1Much;
                image1.SetActive(true);
            }

            if (inv1Much >= 10)
            {
                inv2 = true;
                inv1 = false;
            }
        }

        if (inv2Much <= 10 && inv2 == true)
        {
            inv2Text.text = "" + inv2Much;
            if (inv2Much >= 1)
            {
                inv2Text.text = "" + inv2Much;
                image2.SetActive(true);
            }

            if (inv2Much >= 10)
            {
                inv3 = true;
                inv2 = false;
            }
        }

        if (inv3Much <= 10 && inv3 == true)
        {
            if (inv3Much >= 1)
            {
                inv3Text.text = "" + inv3Much;
                image3.SetActive(true);
            }
            if (inv3Much >= 10)
            {
                inv4 = true;
                inv3 = false;
            }
        }

            if (inv4Much <= 10 && inv4 == true)
            {
                if (inv4Much >= 1)
            {
                inv4Text.text = "" + inv4Much;
                image4.SetActive(true);
            }

            if (inv4Much >= 10)
                {
                    inv4 = false;
                }
            }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("UsedOne");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("UsedTwo");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("UsedThree");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("UsedFour");
        }
    }
}