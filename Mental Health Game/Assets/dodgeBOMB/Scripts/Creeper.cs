using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Creeper : MonoBehaviour
{

    public float speeds = 5f;
    public Rigidbody2D rb;
    public TextMeshProUGUI scoreS;
    private int scoreDB;

    public GameObject gameoverRandSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("dodgebombSCORE"));

        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPosition.x < 0)
            {
                rb.AddForce(Vector2.left * speeds * Time.deltaTime);
            }
            else
            {
                rb.AddForce(Vector2.left * -speeds * Time.deltaTime);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Bomb")
        {
            scoreDB = int.Parse(scoreS.text);

            if (PlayerPrefs.GetInt("dodgebombSCORE") < scoreDB)
            {
                PlayerPrefs.SetInt("dodgebombSCORE", scoreDB);
            }

            //Pausemenu or MH panel active
            Time.timeScale = 0f;
            gameoverRandSprite.SetActive(true); 
        }
    }
}
