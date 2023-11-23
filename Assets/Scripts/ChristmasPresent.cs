using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject present1;
    public GameObject present2;
    public GameObject present3;
    public GameObject present4;

    // This script will simply instantiate the Prefab when the game starts.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Generate a random number between 1 and 4 (inclusive).
            int randomPresent = Random.Range(1, 5);

            // Instantiate the corresponding present based on the random number.
            switch (randomPresent)
            {
                case 1:
                    Instantiate(present1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(present2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(present3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(present4, transform.position, Quaternion.identity);
                    break;
                default:
                    // This should not happen, but you can handle it if needed.
                    break;
            }
        }
    }
}

