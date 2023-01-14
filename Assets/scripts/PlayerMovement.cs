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
            Dead1();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike2")
        {
            Dead2();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike3")
        {
            Dead3();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike4")
        {
            Dead4();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike5")
        {
            Dead5();
			Debug.Log("hit!");
        }

        if(collision.gameObject.tag == "Spike6")
        {
            Dead5();
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
            Dead1();
            Debug.Log("hit!");
        }

        if(other.gameObject.tag == "Spike2")
        {
            Dead2();
            Debug.Log("hit!");
        }

        if(other.gameObject.tag == "Spike3")
        {
            Dead3();
            Debug.Log("hit!");
        }

        if(other.gameObject.tag == "Spike4")
        {
            Dead4();
            Debug.Log("hit!");
        }

        if(other.gameObject.tag == "Spike5")
        {
            Dead5();
            Debug.Log("hit!");
        }

        if(other.gameObject.tag == "Spike6")
        {
            Dead6();
            Debug.Log("hit!");
        }

       
    }

    public void Dead1()
	{
		animator.SetBool("IsDead", true);
        deadCountdown1();
	}

    public void Dead2()
	{
		animator.SetBool("IsDead", true);
        deadCountdown2();
	}

    public void Dead3()
	{
		animator.SetBool("IsDead", true);
        deadCountdown3();
	}

    public void Dead4()
	{
		animator.SetBool("IsDead", true);
        deadCountdown4();
	}

    public void Dead5()
	{
		animator.SetBool("IsDead", true);
        deadCountdown5();
	}

    public void Dead6()
	{
		animator.SetBool("IsDead", true);
        deadCountdown6();
	}


    void deadCountdown1()
    {
        StartCoroutine(deadScene1());
    }

    void deadCountdown2()
    {
        StartCoroutine(deadScene2());
    }

    void deadCountdown3()
    {
        StartCoroutine(deadScene3());
    }

    void deadCountdown4()
    {
        StartCoroutine(deadScene4());
    }

    void deadCountdown5()
    {
        StartCoroutine(deadScene5());
    }

    void deadCountdown6()
    {
        StartCoroutine(deadScene6());
    }



    void victoryCountdown()
    {
        StartCoroutine(victoryScreen());
    }



    IEnumerator deadScene1()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(16);
    }

    IEnumerator deadScene2()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(17);
    }

    IEnumerator deadScene3()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(18);
    }

    IEnumerator deadScene4()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(19);
    }

    IEnumerator deadScene5()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(20);
    }

    IEnumerator deadScene6()
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
