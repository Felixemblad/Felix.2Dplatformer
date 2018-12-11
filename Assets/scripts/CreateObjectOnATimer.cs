using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectOnATimer : MonoBehaviour
{
    //var obijectet spawner
    public Transform spawnarea;
    //vad obijectet heter
    public GameObject prefab;
    //timer
    public float timer = 9f;
   
    // Update is called once per frame
    void Update()
    {
        //om timer är störe en 1 
        if (timer > 0)
        {
            //ta bort tid beroande på hur långt det har gott
            timer -= Time.deltaTime;
        }
        //om timer är mindre än 0 eller =0
        if (timer <= 0)
        {
            //gör en koppia av obijectet på positchonen av den givna spawnarea och dens rotation<
            Instantiate(prefab, spawnarea.position, spawnarea.rotation);

        }


    }
}
