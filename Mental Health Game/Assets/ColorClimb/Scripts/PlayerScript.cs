
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jumpforce = 15f;
    public SpriteRenderer spr;
    public string currentColor;
    public Text Score;
    [SerializeField] Transform tr;
    public Color blue;
    public Color yellow;
    public Color violet;
    public Color pink;
    public Camera mainCamera;

    public GameObject bombEffect;

    private float highestYPosition = 0f;
    private int currentScore = 0;

    public GameObject GameoverMenu;


    // Start is called before the first frame update
    void Start()
    {
        SetRandomcolor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * Jumpforce;
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = Vector2.left * Jumpforce;
        }

        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * Jumpforce;
        }

        //Vector2 temp = Input.acceleration;
        //rb.AddForce(temp*10);

        if (transform.position.y < mainCamera.transform.position.y - 22)
        {
            Invoke("Restart", 1f);
            return;
        }

        if (transform.position.y > highestYPosition)
        {
            // Update the highest Y position
            highestYPosition = transform.position.y;

            // Update the score
            currentScore = Mathf.FloorToInt(highestYPosition)*10;
        }

        Score.text = (currentScore).ToString("0");

        Debug.Log(PlayerPrefs.GetInt("colorclimbSCORE"));
        
    }

    private void OnTriggerEnter2D(Collider2D collides)
    {
        Debug.Log(collides.tag);

        if (collides.tag == currentColor)
        {
            Debug.Log("Congrats ! you earned 1 point.");
        }

        if (collides.tag == "colorChanger")
        {
            SetRandomcolor();
            Destroy(collides.gameObject);
            return;
        }

        if (collides.tag != currentColor)
        {
            if (PlayerPrefs.GetInt("colorclimbSCORE") < currentScore)
            {
                PlayerPrefs.SetInt("colorclimbSCORE", currentScore);
            }

            Debug.Log("GAME OVER !");
            Instantiate(bombEffect, transform.position, Quaternion.identity);
            Destroy(bombEffect);

            Time.timeScale = 0;
            GameoverMenu.SetActive(true);

        }
    }



    void SetRandomcolor()
    {
        int Playercolor = Random.Range(0,4);

        switch (Playercolor)
        {
            case 0:
                currentColor = "blue";
                spr.color = blue;
                break;
            case 1:
                currentColor = "yellow";
                spr.color = yellow;
                break;
            case 2:
                currentColor = "violet";
                spr.color = violet;
                break;
            case 3:
                currentColor = "pink";
                spr.color = pink;
                break;

        }
    }
    
     void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
