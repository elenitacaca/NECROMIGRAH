using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menumuerte : MonoBehaviour

{

  /*public GameObject menuGameOver;

  private MovPersonaje movPersonaje;

  private void Start(){
    movPersonaje = GameObject.FindGameObjectWithTag("Player").GetComponent<MovPersonaje>();
    movPersonaje.MuerteJugador += ActivarMenu;
  }

  private void ActivarMenu(object sender, EventArgs e){
    menuGameOver.SetActive(true);
  }*/
  
 GameObject rip;
    GameObject retry;
    GameObject home;
    private int vida;
    private int estoyMuerto;
    void Start()
{
       rip = GameObject.Find("rip");
       rip.SetActive(false);

     if(GameManager.estoyMuerto){
         rip = GameObject.Find("rip");
           rip.SetActive(true);

        }

        retry = GameObject.Find("retry");
        retry.SetActive(false);
        

         if(GameManager.estoyMuerto){
         retry = GameObject.Find("retry");
           retry.SetActive(true);

        }

        home = GameObject.Find("home");
        home.SetActive(false);
        

         if(GameManager.estoyMuerto){
         home = GameObject.Find("home");
           home.SetActive(true);
         }
}
public void reiniciar()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

 public void Menuprincipal(String nombre)
 {
     SceneManager.LoadScene(nombre);
 }

 public void StartGame(){

        SceneManager.LoadScene("Escena1");
        }

      public void Menuprincipal(){
       
        SceneManager.LoadScene("Menuprincipal");
        }














}
   