using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Periodico : MonoBehaviour
{

    public float cantidadPuntos;

    public Puntaje puntaje;
    // Start is called before the first frame update
     void Start()
    {
        //miAnimadorController = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter2D(Collider2D col){

   Debug.Log(col);

   if(col.name == "Personaje"){
      
      //puntaje.SumarPuntos(cantidadPuntos);
      GameManager.puntos += 1;
      //miAnimadorController.SetBool("monedaDestruir", true);
      Destroy(this.gameObject, 0.5f);

   }

   }

}
