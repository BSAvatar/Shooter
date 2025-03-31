using UnityEngine;
public class EnemyType2 : MonoBehaviour
{
    public float speed = 3f;
    private float direction;

    void Start()
    {
        direction = Random.Range(0, 2) == 0 ? -1 : 1; // Randomly move left or right
    }

    void Update()
    {
        transform.position += new Vector3(direction * 2f * Time.deltaTime, -speed * Time.deltaTime, 0);

        // Change direction randomly
        if (Random.value < 0.01f) 
        {
            direction *= -1;
        }

        // Destroy when out of bounds
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
