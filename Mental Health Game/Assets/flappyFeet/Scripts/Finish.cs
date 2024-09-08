using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Finish : MonoBehaviour
{
    public AudioSource finishsound;
    private bool LevelComplete = false;
    public int level = 1 ;

     [SerializeField]  private TextMeshProUGUI LevelText;

    private void Start ()
    {
        finishsound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.name == "Player" && !LevelComplete)
      {
        finishsound.Play();
        Invoke("CompleteLevel",2f);
        LevelComplete = true;
         LevelText.text = "Level : "+level;
      }
    }
    private void CompleteLevel()
    
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
