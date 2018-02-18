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
    public Dictionary<string, List<InventoryItemSO>> items = new Dictionary<string, List<InventoryItemSO>>();

    public bool Add(InventoryItemSO item)
    {
        // Don't do anything if it's a default item
        string itemCategory = item.itemCategory;

        if (items.ContainsKey(itemCategory))
        {
            // Check if out of space
            int categoryCount = items[itemCategory].Count;
            if (categoryCount >= totalSlots)
            {
                print("Not Enough Room.");
                return false;
            }
            items[itemCategory].Add(item);    // Add item to List if List exists
        }
        else
        {
            List<InventoryItemSO> categoryItems = new List<InventoryItemSO>();
            categoryItems.Add(item);
            items.Add(itemCategory, categoryItems); // Create new List and add if List does not exist
        }

        // Trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();


        foreach (var category in items)
        {
            print("Category: " + category.Key);
            var items = category.Value;
            foreach (var categoryItem in items)
            {
                print(categoryItem.name);
                print(categoryItem.description);
            }
            print("\n");
        }
        print("\n\n");
        return true;
    }

    public void Remove(InventoryItemSO item)
    {
        string category = item.itemCategory;
        if (items.ContainsKey(category))
            items[category].Remove(item);
        else
            print("Invalid Category");

        // Trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
