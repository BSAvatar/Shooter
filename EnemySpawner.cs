using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public float spawnRate1 = 1.5f;
    public float spawnRate2 = 2.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy1), 1f, spawnRate1);
        InvokeRepeating(nameof(SpawnEnemy2), 2f, spawnRate2);
    }

    void SpawnEnemy1()
    {
        Instantiate(enemyPrefab1, new Vector3(Random.Range(-8f, 8f), 5f, 0), Quaternion.identity);
    }

    void SpawnEnemy2()
    {
        Instantiate(enemyPrefab2, new Vector3(Random.Range(-8f, 8f), 5f, 0), Quaternion.identity);
    }
}
