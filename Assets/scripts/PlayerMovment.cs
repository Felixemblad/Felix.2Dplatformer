using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
   //en float med ett set värde
    public float MoveSpeed = 6f;
    //en float med ett set värde
    public float JumpSpeed = 12f;

    // binder sig till grundCheker
    public GrundChecker ground;
    //binder sig till rigedbody En rigedbody är det som ger fusic till ett obiject
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //hämter componenten rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //hämtar den Horixontal axis som är knapparna A D och pilarna höger och vänster.och tar det gånger gånger gå farten
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, rbody.velocity.y);
        
         //om du trycker på mellanslag 
        if (Input.GetButtonDown("Jump")) 
        {
            //om mark.is grounded är störe en 0
            if (ground.isGrounded >0) 
            {
                // rbody.fart(styrka) = vector 2 som är x och y (rbody.fart(styrka).X för vi har ingen x,jump speed som är en karft uppåt) 
               rbody.velocity = new Vector2(rbody.velocity.x, JumpSpeed); 
            }
        }

    }
}