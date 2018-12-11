using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    //objectets livstid
    public float lifeTime = 8f; 



    // Update is called once per frame
    void Update()
    {
    //om LifeTime är störe än 0
   if(lifeTime > 0) 
        {
          //ta bort tid beroande på hur långt det har gott
            lifeTime -= Time.deltaTime; 
        }
         //om liftiden är mindre eller = 0
        if (lifeTime <= 0) 
        {
            //så försör det obiject
            Destroy(gameObject); 
        }
    }
}
