using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaVerde : MonoBehaviour

{
    public float puntos;
   
    GameObject portal;
    // Start is called before the first frame update
<<<<<<< HEAD
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Escena2");
        }
=======
   // private void OnTriggerEnter(Collider other)
   // {
       // if (other.tag == "Player")
       // {
          //  SceneManager.LoadScene("MenuGanar");
       // }
   // }

   //void Start(){

   // if
   //}
   //void Start()
    //{
      // portal = GameObject.Find("portal");
       // portal.SetActive(false);

       // if(cantidadPuntos = 6){

        //}
   // }
   void Start (){

    GameObject.Find("portal").SetActive(false);
    
   }

   void Update(){

    if(GameManager.Instance.getPuntos() >= 6){
       
       GameObject.Find("portal").SetActive(true);
    }
   }
   void OnTriggerEnter2D(Collider2D col){

    

   if(col.name == "Personaje"){
     
        SceneManager.LoadScene("MenuGanarr");
    
    
      }
>>>>>>> 66b6003bb75a53a35f7174f96467ff7d9aa57d3d
    }

}
