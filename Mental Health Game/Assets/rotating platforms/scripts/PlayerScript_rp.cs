using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerScript_rp : MonoBehaviour
{
    public Camera cam;
    
    public Transform tr;
    public Text Score;
    public GameObject PauseMenu;
    public static bool isPaused = true;
 
    [SerializeField] private int PlayTimeScore;

    private float highestXPosition = 0f;
    private int currentScore_RP = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("rotatingplatformSCORE"));
    }

    // Update is called once per frame
    void Update()
    {

        if (cam.transform.position.x > highestXPosition)
        {
            
            highestXPosition = cam.transform.position.x;

            // Update the score
            int scoreRP = (int)highestXPosition * 20;
            Score.text = scoreRP.ToString();
        } 
        //if (tr.position.x >= 0)
        //{
        //    int scoreRP = (int)cam.transform.position.x * 20;
        //    Score.text = scoreRP.ToString("0");
        //}
       

        Debug.Log(PlayerPrefs.GetInt("rotatingplatformSCORE"));
    }

    private void OnCollisionEnter(Collision collides)
    {
        if(collides.collider.name == "Ground")
        {
            Debug.Log("GAME OVER");
            Invoke("die", 0.5f);
            return;
        }

        if(collides.collider.tag == "platform")
        {
            FindObjectOfType<Audiomanager>().Play("Bounce");
        }
    }
    public void die()
    {
        PlayTimeScore = int.Parse(Score.text);

        if (PlayerPrefs.GetInt("rotatingplatformSCORE") < PlayTimeScore)
        {
            PlayerPrefs.SetInt("rotatingplatformSCORE", PlayTimeScore);
        }

        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }


}
