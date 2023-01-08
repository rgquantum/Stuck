using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;      
    bool crouch = false;

    
    
    private int victoryNext;

    void Start() 
    {
    victoryNext = SceneManager.GetActiveScene().buildIndex + 1 ;    
    }

    void Update()
    {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;  
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false; 
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump); //move our character
        jump = false;    
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
         animator.SetBool("IsCrouching", isCrouching);
    }

    	private void OnTriggerEnter2D(Collider2D collision)  
	{
		if(collision.gameObject.tag == "Spike")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike1")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike2")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike3")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike4")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike5")
        {
            Dead();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike6")
        {
            Dead();
			Debug.Log("hit!");
        }

		if(collision.gameObject.name == "JumpDown")
        {
           
        }

        if(collision.gameObject.name == "EndCollision")
        {
            victoryCountdown();
        }

        if(collision.gameObject.name == "Final")
        {
            SceneManager.LoadScene(14);
        }

        if(collision.gameObject.name == "endRural")
        {
            victoryCountdown();
        }

        if(collision.gameObject.tag == "Map")
        {
            Destroy(collision.gameObject);   
        }
         
        if(collision.gameObject.name == "endUrban")
        {
            victoryCountdown();
        }

        if(collision.gameObject.name == "sewerEnd")
        {
            victoryCountdown();
        }
	}



    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Spike")
        {
            Dead();
            Debug.Log("hit!");
        }

       
    }

    public void Dead()
	{
		animator.SetBool("IsDead", true);
        deadCountdown();
	}


    void deadCountdown()
    {
        StartCoroutine(deadScene());
    }

    void victoryCountdown()
    {
        StartCoroutine(victoryScreen());
    }



    IEnumerator deadScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }

    IEnumerator victoryScreen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(victoryNext);
    }

    

}
