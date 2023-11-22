using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static int OrnamentsOnTree = 0;
    private Vector3 screenPosition;
    private Vector3 targetWorldPosition;
    private int maxRayDistance = 10;
    [SerializeField] private LayerMask layersToHit;
    private GameObject heldObject = null;
    [SerializeField] private Vector3 heldPosition;

    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hitdata, maxRayDistance, layersToHit))
            {
                targetWorldPosition = hitdata.point;
                GameObject hitObj = hitdata.transform.gameObject;
                if (hitObj.CompareTag("Pickup"))
                {
                    // do we have held object?
                    if (heldObject == null)
                    {
                        // if no, pick up this object.
                        heldObject = hitObj;
                        heldObject.transform.position = heldPosition;
                        heldObject.GetComponent<Collider>().enabled = false;
                    }
                }
                if (hitObj.CompareTag("Tree"))
                {
                    // do we have held object?
                    if (heldObject!=null)
                    {
                        // if yes, put its position to targetworld position, set tree as parent and remove the heldobj reference
                        heldObject.transform.position = targetWorldPosition;
                        heldObject.transform.SetParent(hitObj.transform);
                        heldObject = null;
                        OrnamentsOnTree++;
                    }

                }

            }
        }
    }
}
