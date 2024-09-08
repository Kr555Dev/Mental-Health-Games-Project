using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManagerScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        public void Pause()
        {

            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }

        public void Restart()
        {

            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

    }

        public void SubmitScore()
    {
        //submitScore
    }
    
}
