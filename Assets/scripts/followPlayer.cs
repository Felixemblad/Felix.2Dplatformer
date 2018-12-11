using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    // hämter targets position
    private Transform target;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //hittar spelaren genom att hitta vilken Transformkordinaterna är
    }

    // Update is called once per frame
    void Update()
    {
         // om vector2 är störe än stoppdistansen
        if(Vector2.Distance(transform.position,target.position) > stoppingDistance) 
        {            
            //rör sig mot spelaren i en fart oberoande av Fps och en fart sat av spelaren som är variabeln speed  och så rör den sig mot spelarens position
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); 
        }
    }
}
