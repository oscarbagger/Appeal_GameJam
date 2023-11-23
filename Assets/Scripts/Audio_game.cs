using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_game : MonoBehaviour
{
    Audio_Man Audio;
    private void Awake()
    {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Man>();
        Audio.firstLoop();
    }
}
