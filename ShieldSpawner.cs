using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    public GameObject shieldPowerUpPrefab;
    public float spawnInterval = 10f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnShield), 5f, spawnInterval);
    }

    void SpawnShield()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);
        Vector3 spawnPos = new Vector3(x, y, 0);
        Instantiate(shieldPowerUpPrefab, spawnPos, Quaternion.identity);
    }
}
