using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class portales : MonoBehaviour
{
    public GameObject salida;

    public bool enterDesdeDerecha ;
     GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name == "Personaje"){

            personaje.transform.position = salida.transform.position;
          
            
        }
    }
}
