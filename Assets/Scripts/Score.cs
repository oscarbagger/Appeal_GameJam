using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text m_MyText;

    // Start is called before the first frame update
    void Start()
    {
        m_MyText.text = "this is my text";
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Pickup.OrnamentsOnTree);

        if(Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "My text has now changed";
        }

    }
}
