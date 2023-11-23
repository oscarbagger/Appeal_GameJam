using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Audio_Man Audio;
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Man>();
        Audio.Intro();
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
