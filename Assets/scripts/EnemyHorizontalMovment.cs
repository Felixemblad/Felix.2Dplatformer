using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovment : MonoBehaviour
{
    public float speed = 1f;
    public bool left = true;
    //en rigebody2dsom nu heter rbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //hämtar Rigetbody 2D
        rbody = GetComponent<Rigidbody2D>(); 
    }
     //updateras med en fast summa gånger per secund 
    private void FixedUpdate() 
    {
        //om vänster är = vänster 
        if (left == true) 
        {
            //Rigebodys(rbody) Hastighet = -höger gånger fart alltså så går den vänster
            rbody.velocity = -(Vector2)transform.right * speed; 
            //sätter skalan på 1.1.1 alltså som vanligt
            transform.localScale = new Vector3(1, 1, 1); 
        }
      //Anars 
        else 
        {
            //Rigeboys(rbody) Hastighet =höger går åt höger 
            rbody.velocity = (Vector2)transform.right * speed; 
           //sätter skalan på -1 1 1 alltså tvärt om som vanligt spriten byter hål
            transform.localScale = new Vector3(-1, 1, 1); 
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        // kollar om det du träfar har tagen Inviseblewall
        if (collision.tag == "Inviseblewall") 
        {
          // om den går vänster så blir det inte vänster
            left = !left; 
        }
    }
}



