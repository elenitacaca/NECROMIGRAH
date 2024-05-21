using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float multiplicador = 5f;

    public float multiplicadorSalto = 5f;

    public bool miraDerecha = true;

    private bool puedoSaltar = true;

    private Rigidbody2D rb; 

    GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
       rb =  GetComponent<Rigidbody2D>();

       respawn = GameObject.Find("Respawn");

      Respawnear();
    }

    // Update is called once per frame
    void Update()
    {
        float movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)

        float miDeltaTime = Time.deltaTime;

    
        /*transform.Translate(
            movTeclas*(Time.deltaTime*multiplicador),
            0,
            0
        );*/

        //movimiento personaje

        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        //izq <--
        if(movTeclas < 0){
          this.GetComponent<SpriteRenderer>().flipX = true;  
          miraDerecha = false;
        }else if(movTeclas > 0){

        //dcha
          this.GetComponent<SpriteRenderer>().flipX = false;  
          miraDerecha = true;
        }


        //salto
         RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
            puedoSaltar = true;
            //Debug.Log(hit.collider.name);
        }else{
            puedoSaltar = false;
        }


        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
        rb.AddForce(
            new Vector2(0,multiplicadorSalto),
            ForceMode2D.Impulse
        );

        puedoSaltar = false;
      }

        if(transform.position.y <= -5){
            Respawnear();
        }

    }

    void OnCollisionEnter2D(){
        puedoSaltar = true;
    }

    public void Respawnear(){

        GameManager.vidas = GameManager.vidas -1;

        transform.position = respawn.transform.position;
    }
}