using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCrl : MonoBehaviour
{
    public float Speed = 5;

    public Rigidbody2D rb;

    public Animator animator;
    
    public MaleVillageController currentCharacter;
    public VectorValue playerCurrPos;


    Vector2 movement;

    public void Start()
    {
        transform.position = playerCurrPos.initialValue;
    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        movement.x =  Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x > 0)
        {
            gameObject.transform.localScale = new Vector3(-0.6833039f, 0.613938f, 1);
        }
        if (movement.x < 0)
        {
            gameObject.transform.localScale = new Vector3(0.6833039f, 0.613938f, 1);
        }
        

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }


    void Update()
    {
        if (currentCharacter != null && Input.GetKeyDown(KeyCode.E))
        {
            if(DialogueManager.Instance.isDialogueActive)
            {
                return;
            }
        }
    }
}
