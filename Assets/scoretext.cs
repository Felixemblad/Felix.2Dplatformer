using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Visar att du använder TextMeshPro 
using TMPro; 

public class scoretext : MonoBehaviour
{
    //Detta pekar på att TextMeshProUgUI = Text 
    private TextMeshProUGUI text; 

    // Use this for initialization
    void Start()
    {
       // text som du har scrivit i TextMeshproUgi Hämtas och kommer upp i TextMeshProUgui
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Visar dit score i TextMeshProUGUi här använder vi string format för att ge oss texten som står först
        text.text = string.Format("score: {0:0000}", coin.score); 
       
    }
}
