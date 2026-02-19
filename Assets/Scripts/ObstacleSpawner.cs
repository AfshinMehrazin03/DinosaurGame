using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnX = 10f;
    public float spawnY = -2f;
    
    private float timer;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    void Update()
    {
        if (!gameManager.isGameActive) return;
        
        timer += Time.deltaTime;
        
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
            spawnInterval = Random.Range(1.5f, 3f);
        }
    }
    
    void SpawnObstacle()
    {
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
