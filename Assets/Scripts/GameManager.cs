using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
   public static int vidas = 5;

    public static int puntos = 0;

    public GameObject puntaje;

    public static int muertes = 0;

     public static bool estoyMuerto = false;

     GameObject vidasText;

     //GameObject puntosText;

    void Awake(){
        if(Instance != null && Instance != this ){
            Destroy(this.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        vidasText = GameObject.Find("VidasText");

        //puntosText = GameObject.Find("PuntosText");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Puntos: "+puntos);
        //Debug.Log("Deads: "+muertes);

        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();

        //puntosText.GetComponent<TextMeshProUGUI>().text = puntos.ToString();

        
    }

    public void SumaPuntos(){
        puntos++;
        puntaje.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
    }

    public float getPuntos(){
        return puntos;
    }

}
