using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLootAtPositions : MonoBehaviour {

    [Header("Loot Details")]
    public GameObject lootPositionHolder;
    public GameObject lootHolder;

    [Header("Stats")]
    public int minObjects = 10;
    public List<GameObject> lootObjects;

    private int numberOfSpawnPoints;
    private List<Transform> lootHolderChildren;

    private int currentCount;
    private int maxCount;

    void Start() {
        lootHolderChildren = new List<Transform>();

        numberOfSpawnPoints = lootPositionHolder.transform.childCount;

        currentCount = 0;

        if (minObjects > numberOfSpawnPoints)
            minObjects = numberOfSpawnPoints;

        maxCount = Random.Range(minObjects, lootPositionHolder.transform.childCount);

        for (int i = 0; i < numberOfSpawnPoints; i++)
            lootHolderChildren.Add(lootPositionHolder.transform.GetChild(i));
    }
	
    // Update is called once per frame
    void Update() {
        if (currentCount <= maxCount) {
            int randomPositionIndex = Mathf.FloorToInt(Random.value * lootHolderChildren.Count);
            GameObject randomLoot = lootObjects[Mathf.FloorToInt(Random.value * lootObjects.Count)];

            GameObject loot = Instantiate(randomLoot, lootHolderChildren[randomPositionIndex].position, randomLoot.transform.rotation);
            loot.transform.SetParent(lootHolder.transform);
            lootHolderChildren.RemoveAt(randomPositionIndex);

            currentCount += 1;
        }
    }
}
