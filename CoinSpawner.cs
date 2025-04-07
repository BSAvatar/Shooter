using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 5f;
    private float screenWidth;
    private float screenHeight;

    void Start()
    {
        screenHeight = Camera.main.orthographicSize;
        screenWidth = screenHeight * Camera.main.aspect;
        InvokeRepeating(nameof(SpawnCoin), 2f, spawnInterval);
    }

    void SpawnCoin()
    {
        float x = Random.Range(-screenWidth + 1, screenWidth - 1);
        float y = Random.Range(-screenHeight + 1, screenHeight - 1);
        Vector3 spawnPos = new Vector3(x, y, 0);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}
