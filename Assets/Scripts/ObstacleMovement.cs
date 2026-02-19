using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;
    private float leftBoundary = -10f;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    void Update()
    {
        if (gameManager.isGameActive)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        
        if (transform.position.x < leftBoundary)
        {
            Destroy(gameObject);
        }
    }
}
