using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 7;
    public float deadZone = -42;
    
    public PipeSpawnScript pss;
    // Start is called before the first frame update
    void Start()
    {
        // pss = GameObject.FindGameObjectWithTag("Spawnner").GetComponent<PipeSpawnScript>();
        // moveSpeed = pss.pipeSpeed;
    }

        
        
    

    // Update is called once per frame
    void Update()
    {
    

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime ;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
