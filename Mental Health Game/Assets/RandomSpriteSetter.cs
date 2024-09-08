using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomSpriteSetter : MonoBehaviour
{
    public Sprite[] sprites; // Array of sprites to choose from
    public Image imageComponent; // Reference to the Image component on the UI panel

    private void Start()
    {
        // Generate a random index
        int randomIndex = Random.Range(0, sprites.Length);

        // Set the sprite on the Image component
        imageComponent.sprite = sprites[randomIndex];
    }

    public void ReturntoMain()
    {
        SceneManager.LoadScene("StartScreen_mh");
    }
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}