using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrundChecker : MonoBehaviour
{
    public int isGrounded;

    //När du nuddar något
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // läger till +2 på isgrounded variabeln
        isGrounded++; 
    }
    //När du slutar att nudda något 
    private void OnTriggerExit2D(Collider2D collision) 
    {
        // tar bort-2 på isgrounded variabeln
        isGrounded--; 
    }
}
