using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public float duration = 5f; // how long the shield lasts
    public AudioClip shieldUpSound;

    void Start()
    {
        Destroy(gameObject, 7f); // auto destroy after 7 seconds if not picked up
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerShield playerShield = other.GetComponent<PlayerShield>();
            if (playerShield != null)
            {
                playerShield.ActivateShield(duration);
                AudioSource.PlayClipAtPoint(shieldUpSound, transform.position);
            }
            Destroy(gameObject);
        }
    }
}
