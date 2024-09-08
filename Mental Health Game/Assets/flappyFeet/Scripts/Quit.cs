using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   
    [SerializeField] AudioSource QuitSound;
    public void QuitGame()
    {
        QuitSound.Play();
        Application.Quit();
    }
}
