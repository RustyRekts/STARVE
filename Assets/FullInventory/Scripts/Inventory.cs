using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    public static bool redCanHas;
    public static bool greenCanHas;
    public static bool blueCanHas;


    //Is taken 1
    public static bool isTaken1;

    //Is taken 2
    public static bool isTaken2;

    //Can Red1
    public Image canRed1;
    public static bool isCanRed1;

    //Can Blue1
    public Image canBlue1;
    public static bool isCanBlue1;

    //Can Green1
    public Image canGreen1;
    public static bool isCanGreen1;

    //Can Red2
    public Image canRed2;
    public static bool isCanRed2;

    //Can Blue2
    public Image canBlue2;
    public static bool isCanBlue2;

    //Can Green2
    public Image canGreen2;
    public static bool isCanGreen2;

    public static Dictionary<string, int> lootTypes;

    void Awake() {
        isTaken2 = true;

        //1
        canRed1.enabled = false;
        canBlue1.enabled = false;
        canGreen1.enabled = false;

        //2
        canRed2.enabled = false;
        canBlue2.enabled = false;
        canGreen2.enabled = false;

        lootTypes = new Dictionary<string, int>();
    }

    public static void AddLootToInventory(string lootType) {
        if (!lootTypes.ContainsKey(lootType))
            lootTypes.Add(lootType, 1);
        else
            lootTypes[lootType] += 1;
    }

    void Update() {
        //1CanRed
        if (isCanRed1 == true && isTaken1 == false) {
            redCanHas = true;
            canRed1.enabled = true;
            isTaken1 = true;
            isTaken2 = false;
        }

        //1CanBlue
        if (isCanBlue1 == true && isTaken1 == false) {
            canBlue1.enabled = true;
            isTaken1 = true;
            isTaken2 = false;
            blueCanHas = true;
        }

        //1CanGreen
        if (isCanGreen1 == true && isTaken1 == false) {
            canGreen1.enabled = true;
            isTaken1 = true;
            isTaken2 = false;
            greenCanHas = true;
        }

        //2CanRed
        if (isCanRed2 == true && isTaken2 == false) {
            redCanHas = true;
            canRed2.enabled = true;
            isTaken2 = true;
        }

        //2CanBlue
        if (isCanBlue2 == true && isTaken2 == false) {
            canBlue2.enabled = true;
            isTaken2 = true;
            blueCanHas = true;
        }

        //2CanGreen
        if (isCanGreen2 == true && isTaken2 == false) {
            canGreen2.enabled = true;
            isTaken2 = true;
            greenCanHas = true;
        }
    }
}