using UnityEngine;

public class DinoController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private Animator anim;
    
    public float jumpForce = 10f;
    public GameManager gameManager;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && gameManager.isGameActive)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
            anim.SetBool("isJumping", true);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("isJumping", false);
        }
        
        if (collision.gameObject.CompareTag("Obstacle") && gameManager.isGameActive)
        {
            gameManager.GameOver();
            anim.SetBool("isDead", true);
        }
    }
}
