using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Sprite iconImage;
    public Button removeButton;

    InventoryItemSO itemSO;

    public void AddItem(InventoryItemSO item)
    {
        itemSO = item;

        itemSO.itemImage = iconImage;
        itemSO.itemImageEnabled = true;

        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        itemSO = null;

        itemSO.itemImage = null;
        itemSO.itemImageEnabled = false;

        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        InventoryNew.instance.Remove(itemSO);
    }

    public void UseItem()
    {
        if (itemSO != null)
            itemSO.Use();
    }
}
