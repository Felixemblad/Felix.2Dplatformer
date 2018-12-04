using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//visar till unity att du vill använda sceneladningar
using UnityEngine.SceneManagement; 



public class loadgame : MonoBehaviour
{
    //om du har mindre en detta poänget så kommer barnan inte att ladda
    public int minimumScoreNeded = 0; 
    //namnet på scenen 
    public string sceneToLoad = "scene1";
    //laddar spelet om du triggar en hitbox.
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //om objectet mad tagen Player nudar en hitboxmed trigger och att din coin.score är störe än minimumScoreNeded
        if (collision.tag == "Player" && coin.score >= minimumScoreNeded) 
        {
           //Du börjar på 0 coin efter att scenen är laddad
            coin.score = 0;
            //Kallar på att du ska ladda scenen 
            SceneManager.LoadScene("scene1"); 
        }
    }



}
