using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RegenerateLoot : MonoBehaviour {

    [Header("Time In Minutes")]
    public float regenerateAfter = 30;

    [Header("Tag Name")]
    public string playerTagName = "Player";
    

    private Collider objectCollider;
    private int childCount;

    void Start() {
        childCount = gameObject.transform.childCount;
        objectCollider = gameObject.GetComponent<Collider>();
    }

    public IEnumerator ResetObject() {
        print("Loot Collected");

        objectCollider.enabled = false;
        for (int i = 0; i < childCount; i++)
            gameObject.transform.GetChild(i).gameObject.SetActive(false);

        yield return new WaitForSeconds(regenerateAfter * 60);

        objectCollider.enabled = true;
        for (int i = 0; i < childCount; i++)
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
    }
}
