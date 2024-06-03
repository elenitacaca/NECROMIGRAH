using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour

{
        public AudioClip bandaSonora; 

        public AudioClip FxAtaqueTentaculo; 

        public AudioClip FxBotonExit;

        public AudioClip FxClick1; 

        public AudioClip FxGanar;

        public AudioClip FxMenu;

        public AudioClip FxMuerteMenu;

        public AudioClip FxMuerteNyat;

        public AudioClip FxPapel;

        public AudioClip FxPortal; 


        AudioSource _audioSource;

        public static AudioManager Instance;




        void Awake(){

            if(Istance != null && Instance != this){
                Destroy(this.gameObject);
            }else{
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }


        }


    // Start is called before the first frame update
    void Start()
   {
        _audioSource = this.GetComponent<AudioSource>();
        _audioSource.clip = bandaSonora;
        _audioSource.loop = true;
        _audioSource.Play();
   } 
       

        

    // Update is called once per frame
    void Update()
    {
        
    }
}

