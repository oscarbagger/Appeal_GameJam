using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    [SerializeField] private int rotateSpeed = 20;
    [SerializeField] private CameraZoom zoom;


    // Update is called once per frame
    void Update()
    {
        if (!CameraZoom.zooming)
        {
            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, rotateSpeed * Time.deltaTime);

            }
            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, -rotateSpeed * Time.deltaTime);

            }
            if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
            {
                if (zoom != null)
                {
                    zoom.ZoomIn();
                }
            }
            if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
            {
                if (zoom != null)
                {
                    zoom.ZoomOut();
                }
            }
        }

    }
}
