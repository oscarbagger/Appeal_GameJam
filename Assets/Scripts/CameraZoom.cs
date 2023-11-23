using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Vector3[] CameraPositions;
    private int CameraPositionIndex=0;
    [SerializeField] private float zoomTime;
    [SerializeField] private AnimationCurve cameraAnimCurve;

    private void Start()
    {
        Camera.main.transform.position = CameraPositions[0];
    }

    public void NextCameraPosition()
    {
        if (CameraPositionIndex<CameraPositions.Length-1)
        {
            CameraPositionIndex++;
            StartCoroutine(CameraMovement(CameraPositions[CameraPositionIndex - 1], CameraPositions[CameraPositionIndex], zoomTime));
        }
    }
    public void PreviousCameraPosition()
    {
        if (CameraPositionIndex>0)
        {
            CameraPositionIndex--;
            StartCoroutine(CameraMovement(CameraPositions[CameraPositionIndex+1], CameraPositions[CameraPositionIndex], zoomTime));
        }
    }

    private IEnumerator CameraMovement(Vector3 start, Vector3 end, float time)
    {
        float progress = 0f;
        while (progress < time)
        {
            progress = progress + Time.deltaTime;
            float percent = Mathf.Clamp01(progress / time);
            float curvePercent = cameraAnimCurve.Evaluate(percent);
            transform.position = Vector3.LerpUnclamped(start, end, curvePercent);
            yield return null;
        }
    }
}
