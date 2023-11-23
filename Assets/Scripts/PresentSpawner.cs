using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] presents;
    private bool presentSpawned;
    public Vector3 spawnPosition;

    void Update() {
        if (!presentSpawned && this.transform.childCount == 0) {
            presentSpawned = true;
            int choice = Random.Range(0, presents.Length);
            Instantiate(presents[choice], spawnPosition, Quaternion.identity);
        }
    } 
}

