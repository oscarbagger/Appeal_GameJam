using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject present1;
    public GameObject present2;

    // This script will simply instantiate the Prefab when the game starts.
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)) {
        Instantiate(present1, transform.position, Quaternion.identity);
       }
    }
}
