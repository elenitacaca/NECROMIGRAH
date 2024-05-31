using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float vida;

   private Animator animator;

   private void Start()
   {
    animator = GetComponent<Animator>();

    posicionInicial = transform.position;
        //personaje = GameObject.Find("Personaje");
        personaje = GameObject.FindGameObjectWithTag("Player");
   }

   public void TomarDaño(float daño)
   {
    vida -= daño;

    if (vida <= 0)
    {
        Muerte();
    }
   }

   private void Muerte()
   {
    animator.SetTrigger("Muerte");
   }
 
  Vector3 posicionInicial;
    GameObject personaje;

    public float velocidadFantasma = 10.0f;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, personaje.transform.position);
        float velocidadFinal = velocidadFantasma * Time.deltaTime;

        //Si la distancia del fantasma es mayor que 4, me persigue
        if(distancia <= 4.1f){
                //acción
               //Debug.DrawLine(transform.position, personaje.transform.position, Color.red, 2.5f);
               transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);

              
        }else{
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);
            

        }
        
    }
}
