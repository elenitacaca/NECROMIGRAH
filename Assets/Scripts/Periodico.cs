using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Periodico : MonoBehaviour
{

    public float cantidadPuntos;

    // Start is called before the first frame update
     void Start()
    {
        //miAnimadorController = this.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxPapel);
    }

   void OnTriggerEnter2D(Collider2D col){



   if(col.name == "Personaje"){
         Debug.Log(col);   Debug.Log(col.name);
      //puntaje.SumarPuntos(cantidadPuntos);
      GameManager.Instance.SumaPuntos();
        
      Destroy(this.gameObject, 0.5f);

   }

   }

}
