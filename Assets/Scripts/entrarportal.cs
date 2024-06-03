using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class entrarportal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){

    

   if(col.name == "Personaje"){
     
        SceneManager.LoadScene("MenuGanarr");

        
    
    
      }
    }
}
