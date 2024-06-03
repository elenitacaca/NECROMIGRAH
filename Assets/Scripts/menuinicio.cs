using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuinicio : MonoBehaviour
{

    GameObject panelsettings;
    // Start is called before the first frame update
    void Start()
    {
        panelsettings = GameObject.Find("Panelsettings");
        panelsettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){

        SceneManager.LoadScene("Escena1");
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void MostrarSettings(){
    panelsettings.SetActive(true);
    }

    public void OcultarSettings(){
    panelsettings.SetActive(false);
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarClip(AudioManager.Instance.FxClick1);
    }


}
