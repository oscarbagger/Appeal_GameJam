using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] presents;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            int choice = Random.Range(0, presents.Length);
            Instantiate(presents[choice], transform.position, Quaternion.identity);
        }
    } 
}

