using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemSO : ScriptableObject
{
    public new string name;

    [TextArea]
    public string description;

    public Sprite itemImage;
    public bool itemImageEnabled;

    public int totalQuantity;

    public float buyingCost;
    public float sellingCost;

    public virtual void Use()
    {
        Debug.Log("Using Item: " + name);
    }

    public void RemoveFromInventory()
    {
        InventoryNew.instance.Remove(this);
    }
}
