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
        // AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxMenu);
    }

    public void StartGame(){

        SceneManager.LoadScene("Escena1");
    }

    public void ExitGame(){
        //AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxBotonExit);
        Application.Quit();
    }

    public void MostrarSettings(){
        //AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxClick1);
    panelsettings.SetActive(true);
    }

    public void OcultarSettings(){
    panelsettings.SetActive(false);
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarClipUnavez(AudioManager.Instance.FxClick1);
    }

}
