using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Box : MonoBehaviour
{
    public static int boxes=0;
    Animator Animat;

    // Start is called before the first frame update
    void Start()
    {
        boxes++;
        Animat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.childCount == 0)
        {
            boxes--;
            Animat.SetTrigger("Box_Ball");
        }
    }

}
