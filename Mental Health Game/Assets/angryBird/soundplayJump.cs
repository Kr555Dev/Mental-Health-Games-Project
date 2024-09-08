using UnityEngine;

public class soundplayJump : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
       // audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Check for user input (touch or mouse click)
        if (Input.GetMouseButtonDown(0)) // Left mouse button or touch input
        {
            // Play the audio clip
            audioSource.Play();
        }
    }
}