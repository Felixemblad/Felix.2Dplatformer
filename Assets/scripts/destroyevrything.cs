using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyevrything : MonoBehaviour
{


    //när du colliderar med obijectet s
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om det som colliderar med obijectet har tagen Player 
        if (collision.tag == "Player")
        {
            //förstör spel obijectet 
            Destroy(gameObject);
           
        }
    }
}
    
        
          
          
   
