using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Box : MonoBehaviour
{

    Animator Animat;

    // Start is called before the first frame update
    void Start()
    {
        Animat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.childCount == 0)
        { 
            Animat.SetTrigger("Box_Ball");
            Animat.SetTrigger("Cane_gone");
        }
    }

}
