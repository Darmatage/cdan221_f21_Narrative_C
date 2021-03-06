using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour{

        public static int playerBravery;
		
		public static bool GameisPaused = false;
		public GameObject pauseMenuUI;
		
		public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
		
        //public GameObject textGameObject;


		void Awake (){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }


		void Start (){
                pauseMenuUI.SetActive(false);
				//UpdateScore ();
        }
		

        void Update(){         //delete this quit functionality when a Pause Menu is added
                if (Input.GetKeyDown("escape")){
                    if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }	
                }
        }

		void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }


        public void AddPlayerStat(int amount){
                playerBravery += amount;
                Debug.Log("Current Player Stat = " + playerBravery);
        //      UpdateScore ();
        }


    public int CheckPlayerStat()
    {
        return playerBravery;
    }

    //void UpdateScore () {
    //        Text scoreTemp = textGameObject.GetComponent<Text>();
    //        scoreTemp.text = "Score: " + score; }

    public void StartGame(){
                SceneManager.LoadScene("Scene1_Open");
        }

	public void Credits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
		
		
		public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        } 
}