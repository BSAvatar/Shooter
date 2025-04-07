using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 3f; // how long the coin stays on screen

    void Start()
    {
        Destroy(gameObject, lifetime); // auto destroy after lifetime
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
