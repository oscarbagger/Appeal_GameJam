using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Vector3[] CameraPositions;
    private int CameraPositionIndex=0;
    private AnimationCurve CameraAnimCurve;

    private void Start()
    {
        Camera.main.transform.position = CameraPositions[0];

    }

    public void NextCameraPosition()
    {
        if (CameraPositionIndex<CameraPositions.Length-1)
        {
            CameraPositionIndex++;
            Camera.main.transform.position = CameraPositions[CameraPositionIndex];
        }
    }
    public void PreviousCameraPosition()
    {
        if (CameraPositionIndex>0)
        {
            CameraPositionIndex--;
            Camera.main.transform.position = CameraPositions[CameraPositionIndex];
        }
    }

    private IEnumerator CameraMovement()
    {

    }
}
