using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryNew : MonoBehaviour
{


    #region Singleton

    public static InventoryNew instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    [Header("Total Inventory Items")]
    public int totalSlots = 20;
    
    [HideInInspector]
    public List<InventoryItemSO> items = new List<InventoryItemSO>();

    public bool Add(InventoryItemSO item)
    {
        // Don't do anything if it's a default item

        // Check if out of space
        if (items.Count >= totalSlots)
        {
            print("Not Enough Room.");
            return false;
        }

        items.Add(item);    // Add item to list

        // Trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();


        foreach (var tempItem in items)
        {
            print(tempItem.name);
            print(tempItem.description);
            print("\n");
        }
        return true;
    }

    public void Remove(InventoryItemSO item)
    {
        items.Remove(item);     // Remove item from list

        // Trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
