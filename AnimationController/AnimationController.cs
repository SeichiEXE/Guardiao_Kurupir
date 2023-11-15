using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speedX", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("speedY", rb.velocity.y);

        if (rb.velocity.y >= 0) rb.gravityScale = 0.2f;
        if (rb.velocity.y < 0) rb.gravityScale = 8;
        if (Input.GetKeyDown(KeyCode.Z))
            animator.SetTrigger("Shot");
        if (rb.velocity.x > 0) spriteRenderer.flipX = false;
        if (rb.velocity.x < 0) spriteRenderer.flipX = true;
    }


}
