using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class gameLoader : MonoBehaviour
{
    public Text angryHS;
    public Text DodgebombHS;
    public Text infinotoHS;
    public Text colorclimbHS;
    public Text flappyfeetHS;
    public Text RotatepfHS;

    public GameObject Instructions;

    public void Start()
    {
        angryHS.text = PlayerPrefs.GetInt("angrybirdSCORE").ToString();

        colorclimbHS.text= PlayerPrefs.GetInt("colorclimbSCORE").ToString();
        RotatepfHS.text= PlayerPrefs.GetInt("rotatingplatformSCORE").ToString();
        flappyfeetHS.text =  PlayerPrefs.GetInt("flappyfeetSCORE").ToString();
        infinotoHS.text = PlayerPrefs.GetInt("Highscore").ToString();
        DodgebombHS.text = PlayerPrefs.GetInt("dodgebombSCORE").ToString();
    }

    public void InstructionsFunc()
    {
        Instructions.SetActive(true);
    }
    public void ExitInstructions()
    {
        Instructions.SetActive(false);
    }
    public void LoadAngry()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadDB()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadInfinito()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadColorCLimb()
    {
        SceneManager.LoadScene(1);
    }

    public void Loadflappyfeet()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadRP()
    {
        SceneManager.LoadScene(5);
    }

    public void mentalHealth()
    {
        SceneManager.LoadScene(7);
    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
