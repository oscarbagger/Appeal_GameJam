using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] presents;
    private int presentSpawned;
    public Transform spawnLocation;

    void Update() {
        if (presentSpawned < 2 && this.transform.childCount == 0) {
            presentSpawned = presentSpawned + 1;
            int choice = Random.Range(0, presents.Length);
            Instantiate(presents[choice], spawnLocation.position, Quaternion.identity);
        }
    } 
}

