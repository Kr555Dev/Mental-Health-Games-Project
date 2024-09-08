using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicscript logic;
    public bool birdIsAlive = true;
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootForce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < -50)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        if (Input.GetMouseButtonDown(0)) 
        {
             myRigidbody.velocity = Vector2.up * flapStrength;
        }
       // if (Input.GetKeyDown(KeyCode.Space))
        //{
         //   Shoot();
       // }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        
    }

    void Shoot()
    {
        // Create a new instance of the projectile prefab at the shootPoint's position and rotation.
        GameObject newProjectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        // Access the Rigidbody of the new projectile and apply a force to make it move.
        Rigidbody rb = newProjectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
        }
    }
}
