using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float multiplicador = 5f;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        float movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)

        float miDeltaTime = Time.deltaTime;

        Debug.Log(Time.deltaTime);
    
        transform.Translate(
            movTeclas*(Time.deltaTime*multiplicador),
            0,
            0
        );

    }

   

    
}