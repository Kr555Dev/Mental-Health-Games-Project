using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;


    [ContextMenu("Increase score")]
   public void addScore()
   {
    playerScore = playerScore + 50;
    scoreText.text = playerScore.ToString();

   }
   public void restartGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;

   }

   public void gameOver()
   {
        if(PlayerPrefs.GetInt("angrybirdSCORE") < playerScore)
        {
            PlayerPrefs.SetInt("angrybirdSCORE", playerScore);
        }
        
    gameOverScreen.SetActive(true);
        Time.timeScale = 0;

   }
    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("angrybirdSCORE"));
    }

}
