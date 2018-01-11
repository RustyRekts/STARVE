using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Renderer))]
public class RegenerateLoot : MonoBehaviour {

    [Header("Time In Minutes")]
    public float regenerateAfter = 30;

    [Header("Tag Name")]
    public string playerTagName = "Player";

    [Header("Extra Data")]
    public string lootType = "cube";

    private Collider objectCollider;
    private Renderer objectRenderer;

    void Start() {
        objectCollider = gameObject.GetComponent<Collider>();
        objectRenderer = gameObject.GetComponent<Renderer>();
    }

    /* void OnTriggerEnter(Collider other) {
        
        Rigidbody target = other.GetComponent<Rigidbody>();
        if (!target || !other.CompareTag(playerTagName))
            return;

        StartCoroutine(ResetObject());
    } */

    public IEnumerator ResetObject() {
        print("Loot Collected");

        objectCollider.enabled = false;
        objectRenderer.enabled = false;

        yield return new WaitForSeconds(regenerateAfter * 60);

        objectCollider.enabled = true;
        objectRenderer.enabled = true;
    }
}
