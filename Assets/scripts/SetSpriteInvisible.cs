using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Detta sätter sprites som death box och väggar för fienderna osynliga när du spelar 
        GetComponent<SpriteRenderer>().enabled = false; 
    }

}
