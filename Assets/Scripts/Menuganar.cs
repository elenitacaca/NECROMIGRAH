using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuganar : MonoBehaviour
{
    public float cantidadPuntos;
    GameObject panel;
    // Start is called before the first frame update
    void Start()
    {   //if(cantidadPuntos == 6){
         //panel = GameObject.Find("Panel");
        //panel.SetActive(true);

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void StartGame(){
        SceneManager.LoadScene("Escena1");
        AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxClick1);
        AudioManager.Instance.SonarMusica();
    }

    public void Menuprincipal(){
        SceneManager.LoadScene("Menuprincipal");
        AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxClick1);

    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxClick1);
    }


    
}
