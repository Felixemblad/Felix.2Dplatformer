using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createobjects : MonoBehaviour {
     //ett område som heter spawnarea
    public Transform spawnarea; 
     //obectets namn
    public GameObject prefab; 
	//när du nuddar detta
    private void OnTriggerEnter2D() 
    {
         //gör en koppia av obijectet på positchonen av den givna spawnarea och dens rotation
        Instantiate(prefab,spawnarea.position,spawnarea.rotation); 
    }


}
