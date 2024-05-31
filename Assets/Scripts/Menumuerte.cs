using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menumuerte : MonoBehaviour
{
    public float vida;
    GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
         if(vida == 0){
         panel = GameObject.Find("Panel");
        panel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){

        SceneManager.LoadScene("Escena1");
        }

        public void Menuprincipal(){
       
        SceneManager.LoadScene("Menuprincipal");
    }
}
