using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MovPersonaje : MonoBehaviour
{
    public float multiplicador = 5f;

    public float multiplicadorSalto = 5f;

   float movTeclas;

    private bool puedoSaltar = true;

    public bool miraDerecha = true;

    private Rigidbody2D rb;
    
    private Animator animatorController;

    public GameObject oMuerteNyat;

    private AudioSource sMuerteNyat;

    ////public event EventHandler estoyMuerto;

    GameObject respawn;
    GameObject rip;
    GameObject retry;
    GameObject home;
    private int vida;
    //private bool estoyMuerto;
    
    // Start is called before the first frame update
    void Start()
    {
       rb =  GetComponent<Rigidbody2D>();

       animatorController = this.GetComponent<Animator>();

       respawn = GameObject.Find("Respawn");

       transform.position = respawn.transform.position;

       sMuerteNyat = oMuerteNyat.GetComponent<AudioSource>();
       //MENU MUERTE
        //rip = GameObject.Find("rip");
       //rip.SetActive(false);

      //if(GameManager.vidas > 0)
      
       // rip = GameObject.Find("rip");
       // rip.SetActive(true);
      
      //if(GameManager.estoyMuerto == true){
       
      //}
        //if(GameManager.estoyMuerto){
          
         // rip = GameObject.Find("rip");
         // rip.SetActive(true);
         //return;
        //}
         
      //Respawnear();
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.estoyMuerto){
          
          SceneManager.LoadScene("menumuerte");
          return;
        }
       
        float miDeltaTime = Time.deltaTime;

        //MOVIMIENTO

        movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)

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

        //ANIMACION WALKING

        if(movTeclas != 0){
          animatorController.SetBool("activaCamina", true);
        }else{
          animatorController.SetBool("activaCamina", false);
        }


        //salto
         RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f);
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

      }

          //Comprobar si me he salido de la pantalla por abajo
        if(transform.position.y <= -5){
            AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxMuerteNyat);
            Respawnear();
        }

        // 0 vidas

       if(GameManager.vidas <= 0)
       {
        GameManager.estoyMuerto = true;
      //////  estoyMuerto?.Invoke(this, EventArgs.Empty);
       }

    }

    void OnCollisionEnter2D(){
        puedoSaltar = true;
    }

    public void Respawnear(){
     sMuerteNyat.Play();
      Debug.Log("vidas: "+GameManager.vidas);
      GameManager.vidas = GameManager.vidas - 1;
      Debug.Log("vidas: "+GameManager.vidas);

        transform.position = respawn.transform.position;

      //Debug.Log("puntos: "+GameManager.puntos);
      //GameManager.puntos = GameManager.puntos + 1;
      //Debug.Log("puntos: "+GameManager.puntos);
    }
}