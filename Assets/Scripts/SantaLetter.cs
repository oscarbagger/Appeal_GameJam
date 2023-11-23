using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaLetter : MonoBehaviour
{
    // Start is called before the first frame update
    Audio_Man Audio;
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Man>();
        Audio.chimer();
        StartCoroutine(Delay());
    }

// Update is called once per frame

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        Audio.Intro();
    }
    public void NextScene()
    {
        
        SceneManager.LoadScene(2);
        
    }
}
