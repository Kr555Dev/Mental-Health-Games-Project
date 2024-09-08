using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ItemCollector : MonoBehaviour
{

    public int melons = 0 ;
    
    [SerializeField]  private TextMeshProUGUI MelonsText;
    [SerializeField]  AudioSource CollectorSound;
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.gameObject.CompareTag("Melon"))
    {
        Destroy(collision.gameObject);
        melons++;
        Debug.Log("Melons : "+melons);
        MelonsText.text = "SCORE : "+melons*100;

            if (PlayerPrefs.GetInt("flappyfeetSCORE") < melons*100)
            {
                PlayerPrefs.SetInt("flappyfeetSCORE", melons*100);
            }


            CollectorSound.Play();
    }

   }



}
