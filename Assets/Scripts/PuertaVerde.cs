using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaVerde : MonoBehaviour

{
    public float puntos;
   
    GameObject portal;
    // Start is called before the first frame update
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
    portal = GameObject.Find("portal");
    
    portal.SetActive(false);
    
   }

   void Update(){
     Debug.Log(GameManager.Instance.getPuntos());
    if(GameManager.Instance.getPuntos() >= 6){
       
       portal.SetActive(true);
    }
   }
   

}
