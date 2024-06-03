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

        public AudioClip FxMuertbicho;

        public AudioClip FxMuerte;



        AudioSource _audioSource;

        public static AudioManager Instance;




        void Awake(){

            if(Instance != null && Instance != this){
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

   
   //Metodo hacer sonar c lips de audio.
    public void SonarClipUnavez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }

}

