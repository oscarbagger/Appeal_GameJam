using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public static bool zooming=false;
    [SerializeField] private float zoomMultiplierX, zoomMultiplierY, zoomMultiplierZ;

    public int CameraPositions = 3;
    private int activeCameraPosition=1;
    [SerializeField] private float zoomTime;
    [SerializeField] private AnimationCurve cameraAnimCurve;

    public void ZoomOut()
    {
        if (activeCameraPosition<CameraPositions)
        {
            activeCameraPosition++;
            Vector3 newPosition = new Vector3(Camera.main.transform.position.x * zoomMultiplierX, Camera.main.transform.position.y * zoomMultiplierY, Camera.main.transform.position.z * zoomMultiplierZ);
            StartCoroutine(CameraMovement(Camera.main.transform.position,newPosition , zoomTime));
        }
    }
    public void ZoomIn()
    {
        if (activeCameraPosition>1)
        {
            activeCameraPosition--;
            Vector3 newPosition = new Vector3(Camera.main.transform.position.x /zoomMultiplierX, Camera.main.transform.position.y / zoomMultiplierY, Camera.main.transform.position.z / zoomMultiplierZ);
            StartCoroutine(CameraMovement(Camera.main.transform.position, newPosition, zoomTime));
        }
    }

    private IEnumerator CameraMovement(Vector3 start, Vector3 end, float time)
    {
        zooming = true;
        float progress = 0f;
        while (progress < time)
        {
            progress = progress + Time.deltaTime;
            float percent = Mathf.Clamp01(progress / time);
            float curvePercent = cameraAnimCurve.Evaluate(percent);
            transform.localPosition = Vector3.LerpUnclamped(start, end, curvePercent);
            yield return null;
        }
        zooming = false;
    }
}
