using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static int OrnamentsOnTree = 0;
    private Vector3 screenPosition;
    private Vector3 targetWorldPosition;
    private float groundOffset = 0.3f;
    private int maxRayDistance = 10;
    [SerializeField] private LayerMask layersToHit;
    private GameObject heldObject = null;
    [SerializeField] private Vector3 heldPosition;

    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if (Input.GetMouseButtonDown(0))
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
                        PickUpObject(hitObj);
                    }
                    //switch with other object if one already being held.
                    if (heldObject!=null)
                    {
                        // check what it is switching with to see if it needs gravity
                        if (hitObj.transform.parent==null)
                        {
                            heldObject.GetComponent<Rigidbody>().isKinematic = false;
                            PutDownObject(heldObject, targetWorldPosition);
                        }
                        else if (hitObj.transform.parent.CompareTag("Tree"))
                        {
                            PutDownObject(heldObject, targetWorldPosition,hitObj.transform.parent);
                        } else
                        {
                            heldObject.GetComponent<Rigidbody>().isKinematic = false;
                            PutDownObject(heldObject, targetWorldPosition);
                        }
                        // switch out with the new object
                        PickUpObject(hitObj);
                    }
                }
                if (hitObj.CompareTag("Tree"))
                {
                    // do we have held object?
                    if (heldObject!=null)
                    {
                        // if yes, put it on the tree
                        PutDownObject(heldObject, targetWorldPosition, hitObj.transform);
                        OrnamentsOnTree++;
                    }
                }
                if(hitObj.CompareTag("Ground"))
                {
                    // do we have held object?
                    if (heldObject != null)
                    {
                        // if yes, put it down
                        Vector3 putdownTarget = new Vector3(targetWorldPosition.x, targetWorldPosition.y + groundOffset, targetWorldPosition.z);
                        heldObject.GetComponent<Rigidbody>().isKinematic = false;
                        PutDownObject(heldObject, putdownTarget);
                    }
                }

            }
        }
    }
    private void PickUpObject(GameObject obj)
    {
        heldObject = obj;
        heldObject.transform.position = heldPosition;
        heldObject.transform.SetParent(null);
        heldObject.GetComponent<Rigidbody>().isKinematic = true;
    }
    private void PutDownObject(GameObject obj, Vector3 target)
    {
        heldObject.transform.position = target;
        heldObject = null;
    }
    private void PutDownObject(GameObject obj, Vector3 target, Transform parent)
    {
        heldObject.transform.position = target;
        heldObject.transform.SetParent(parent);
        heldObject = null;
    }
}
