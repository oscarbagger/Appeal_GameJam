using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
    private Vector3 screenPosition;
    public GameObject ornament;
    public float spawnForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            screenPosition = Input.mousePosition;
            //Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            Vector3 point= Camera.main.ScreenToWorldPoint(new Vector3(screenPosition.x,screenPosition.y, Camera.main.nearClipPlane));
            GameObject newOrnament = Instantiate(ornament,point,Quaternion.identity);
            newOrnament.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            newOrnament.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,spawnForce));
        }
    }
}
