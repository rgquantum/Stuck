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

		if(collision.gameObject.name == "JumpDown")
        {

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

    IEnumerator deadScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }

}
