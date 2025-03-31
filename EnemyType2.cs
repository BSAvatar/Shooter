using UnityEngine;
public class EnemyType2 : MonoBehaviour
{
    public float speed = 3f; // Speed of enemy movement

    void Update()
    {
        // Move downward
        transform.position += Vector3.down * speed * Time.deltaTime;

        // Destroy when out of bounds
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
