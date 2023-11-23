using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaLetter : MonoBehaviour
{
    Audio_Man Audio;
    // Start is called before the first frame update
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Man>();
        Audio.Intro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        
        SceneManager.LoadScene(2);
        
    }
}
