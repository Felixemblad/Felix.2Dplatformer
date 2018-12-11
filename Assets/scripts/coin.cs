using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    //static är en typ av form som gör så att något går att använda i alla kodder 
    public static int score; 
    public int amount = 1;
    private float coinspin = 180;
        //är en annan typ av uppdaterning som oftas användes för effekter för att den har en fast fps detta gör så att efekten inte går snabbare på en viss dator än nogon annan
    private void Update() 
    {
//roterer coinen 180 grader oberonade av fps
        transform.Rotate(0, coinspin * Time.deltaTime, 0); 
        
    }
//när du nuddar ett obiject så händer detta. denna är ochkså privet det betyder att du bara kan ändra det här i scripten
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //om collision tagen är player
       if(collision.tag =="Player")
        {
            //coin.score + mängden 
            coin.score += amount;
            //förstör spel obijectet
            Destroy(gameObject);
           
        }
    }
}
