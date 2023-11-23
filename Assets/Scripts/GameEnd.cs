using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public AnimationCurve rocketCurve;
    public float animationTime;
    public float endPosY=50;
    public float cameraEndPosOffset = 0.5f;
    private bool isFlying = false;
    [SerializeField] private GameObject tree, cam, endGameButton, gameEndText;
    [SerializeField] private ParticleSystem particle;

    private void Start()
    {
        endGameButton.SetActive(false);
        gameEndText.SetActive(false);

    }

    private void Update()
    {
        if (Spawn_Box.boxes==0)
        {
            endGameButton.SetActive(true);
        }
    }
    public void LiftOff()
    {
        if (!isFlying)
        {
            Vector3 endPos = new Vector3(tree.transform.position.x,tree.transform.position.y + endPosY,tree.transform.position.z);
            StartCoroutine(RocketTimer(tree.transform.position,endPos,animationTime,tree));
            Vector3 camEndPos = new Vector3(cam.transform.position.x, cam.transform.position.y + endPosY+cameraEndPosOffset,cam.transform.position.z);
            StartCoroutine(RocketTimer(cam.transform.position, camEndPos, animationTime,cam));
            isFlying = true;
            particle.Play();
        }

    }

    // https://medium.com/@rhysp/lerping-with-coroutines-and-animation-curves-4185b30f6002 
    private IEnumerator RocketTimer(Vector3 start, Vector3 end, float time, GameObject obj)
    {
        float progress = 0f;
        while (progress < time)
        {
            progress = progress + Time.deltaTime;
            float percent = Mathf.Clamp01(progress / time);
            float curvePercent = rocketCurve.Evaluate(percent);
            obj.transform.position = Vector3.LerpUnclamped(start, end, curvePercent);
            yield return null;
        }
        gameEndText.SetActive(true);
    }
}
