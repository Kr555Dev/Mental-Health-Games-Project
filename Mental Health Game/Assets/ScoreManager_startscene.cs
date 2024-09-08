using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager_startscene : MonoBehaviour
{
    // Start is called before the first frame update
    public Text totalScore_text; 
    private int totalSCORE = 0;

    private string email = "";
    public InputField enterEmail;
    public int counter = 0;

    public GameObject check;

    void Start()
    {
        counter = 0;
        PlayerPrefs.SetInt("totalSCORE", 0);
        totalSCORE = PlayerPrefs.GetInt("angrybirdSCORE") +
                     PlayerPrefs.GetInt("colorclimbSCORE") +
                     PlayerPrefs.GetInt("rotatingplatformSCORE") +
                     PlayerPrefs.GetInt("flappyfeetSCORE") +
                     PlayerPrefs.GetInt("Highscore") +
                     PlayerPrefs.GetInt("dodgebombSCORE");//add all
        
        totalScore_text.text = totalSCORE.ToString();
        PlayerPrefs.SetInt("totalSCORE", totalSCORE);

        
    }

    

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSf_Lx51u3IwahMF-zLKATOrDnijKxG1JiakLhHjPs1RgNgbuA/formResponse";

    IEnumerator togoogle()
    {
        email = enterEmail.text;
        string id = email;
        int myscore = PlayerPrefs.GetInt("totalSCORE");
        string score = myscore.ToString();
        WWWForm form = new WWWForm();
        form.AddField("entry.1871645377", id);
        form.AddField("entry.1433395458", score);

        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;
        Debug.Log("should be done");
    }
    public void sendit()
    {
        counter++;
        if (counter >= 2)
        {

        }
        else
        {
            check.SetActive(true);
            StartCoroutine(togoogle());
        }
    }


    void Update()
    {
        
    }
}
