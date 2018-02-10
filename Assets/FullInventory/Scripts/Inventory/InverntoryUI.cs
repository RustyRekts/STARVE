using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverntoryUI : MonoBehaviour
{
    public Transform itemsParent;

    private InventoryNew inventory;
    private InventorySlot[] slots;

    // Use this for initialization
    void Start()
    {
        inventory = InventoryNew.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
                slots[i].AddItem(inventory.items[i]);
			else
				slots[i].ClearSlot();
        }
    }
}
