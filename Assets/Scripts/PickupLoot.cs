using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLoot : MonoBehaviour {

    [Header("Loot Stats")]
    public float lootPickupDistance = 5f;
    public string lootTagName = "Loot";

    [Header("Required Objects")]
    public Camera mainCamera;
	
    // Update is called once per frame
    void Update() {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            if (hit.distance <= lootPickupDistance && hit.collider.gameObject.tag == lootTagName) {
                if (Input.GetKeyDown(KeyCode.E)) {
                    RegenerateLoot regenerateLoot = hit.collider.gameObject.GetComponent<RegenerateLoot>();
                    if (!regenerateLoot)
                        return;

                    Inventory.AddLootToInventory(regenerateLoot.lootType);
                    StartCoroutine(regenerateLoot.ResetObject());
                }
            }
        }
    }
}
