using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    [SerializeField] private int rotateSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, -rotateSpeed * Time.deltaTime);

        }
        else if (Input.GetKey("right"))
        {
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, rotateSpeed * Time.deltaTime);

        }
    }
}
