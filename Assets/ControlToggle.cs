using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlToggle : MonoBehaviour
{ 

    // defining our controlscreen image in code
    public GameObject ControlsScreen;
    public GameObject CloseButton;

    void Start()
    {
        // when the game is opened, have the controls screen not active
        ControlsScreen.gameObject.SetActive(false);
        CloseButton.gameObject.SetActive(false);
    }
    
    public void Switch()
    {
        // if the screen is false, then upon click, set it to true, which then shows the Controls screen.
        if (ControlsScreen.activeSelf == false)
        {
            ControlsScreen.SetActive(true);
        }
        else ControlsScreen.SetActive(false);

        if (CloseButton.activeSelf == false)
        {
            CloseButton.SetActive(true);
        }
        else CloseButton.SetActive(false);
    }
}
