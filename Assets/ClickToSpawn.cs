using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
    private Vector3 screenPosition;
    public GameObject ornament;
    public float spawnForce;
    private int distanceFromScreen = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // get mouse position on screen. 
            screenPosition = Input.mousePosition;
            screenPosition.z = distanceFromScreen;
            // convert screenposition to a world space position
            Vector3 targetpos= Camera.main.ScreenToWorldPoint(screenPosition);
            Vector3 spawnPos= Camera.main.ScreenToWorldPoint(new Vector3(screenPosition.x,screenPosition.y,Camera.main.nearClipPlane));
            // calculate 
            Vector3 moveVector = targetpos - spawnPos;
            // instantiate a new object at spawnPos.
            GameObject newOrnament = Instantiate(ornament, spawnPos, Quaternion.identity);
            // add a force to the new object to make it move. 
            newOrnament.GetComponent<Rigidbody>().AddForce(moveVector.normalized*spawnForce);
        }
    }
}
