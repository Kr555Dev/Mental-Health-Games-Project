using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game__managerss : MonoBehaviour
{

    public GameObject bomb;
    public float maxminX;
    public Transform spawnpoint;
    public float SpawnRate;

    public GameObject taptext;
    public TextMeshProUGUI Score;
    
    private int score = 0;

    bool isGameStarted = false;
    // Start is called before the first frame update


    
    private void StartSpwaning()
    {
        InvokeRepeating("SpawnBlock", 0.6f, SpawnRate);
    }
    private void SpawnBlock() 
    {
        Vector3 spawnPos = spawnpoint.position;
        spawnPos.x = Random.Range(-maxminX, +maxminX);
        Instantiate(bomb, spawnPos, Quaternion.identity);
        score=score+100;
        Score.text = score.ToString();
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isGameStarted)
        {
            StartSpwaning();
            isGameStarted = true;
            taptext.SetActive(false);
        }
    }
}
