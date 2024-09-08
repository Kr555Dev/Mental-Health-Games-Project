using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
    private Animator animator;

    private SpriteRenderer sprite;
    private BoxCollider2D coll ;
   private float directionX = 0f;

    [SerializeField]private float movespeed = 7f;

     [SerializeField]private float jumpforce = 14f;

     [SerializeField] LayerMask JumpGround;

    [SerializeField] AudioSource Jumpsound;

     private enum MovementState {idle , walk , jump}
    
    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        coll = GetComponent <BoxCollider2D>();

        Debug.Log("Akash made this game !");
    }

  
    void Update()
    {

        Debug.Log(PlayerPrefs.GetInt("flappyfeetSCORE"));

         directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2 ( directionX*movespeed , rb.velocity.y );

        
          if(CrossPlatformInputManager.GetButtonDown("Jump") && IsGrounded()) 
         {
           rb.velocity = new Vector2 (rb.velocity.x,jumpforce);
           Jumpsound.Play();
         }


       UpdateAnimationState();

       
         }

         private void UpdateAnimationState()
    {
        MovementState state;

        if (directionX > 0f)
        {
            state = MovementState.walk;
            sprite.flipX = false;
        }
        else if (directionX < 0f)
        {
            state = MovementState.walk;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jump;
        }
        

       
       

        animator.SetInteger("State", (int)state);
    }



    private bool IsGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f,Vector2.down,0.1f,JumpGround);

    }
}


