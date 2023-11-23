using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlToggle : MonoBehaviour
{ 

    // defining our controlscreen image in code
    public GameObject ControlsScreen;

    void Start()
    {
        // when the game is opened, have the controls screen not active
        ControlsScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void ControlsToggle()
    {
        // if the screen is false, then upon click, set it to true, which then shows the Controls screen.
        if (ControlsScreen.activeSelf == false)
        {
            ControlsScreen.SetActive(true);
        }
        else ControlsScreen.SetActive(false);
    }
}
