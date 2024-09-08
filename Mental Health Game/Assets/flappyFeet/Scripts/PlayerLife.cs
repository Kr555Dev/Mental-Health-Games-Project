using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] AudioSource Deathsound;
    public GameObject PanelforQuotes;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {

            Die();
        }
    }

    private void Die()
    {
        PanelforQuotes.SetActive(true);
        rb.bodyType = RigidbodyType2D.Static;
       anim.SetTrigger("Death");
        Deathsound.Play();

    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
