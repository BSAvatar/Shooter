using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public GameObject shieldVisual;
    public AudioClip shieldDownSound;

    private bool isShielded = false;

    public void ActivateShield(float duration)
    {
        if (isShielded) return;

        isShielded = true;
        shieldVisual.SetActive(true);
        Invoke(nameof(DeactivateShield), duration);
    }

    void DeactivateShield()
    {
        isShielded = false;
        shieldVisual.SetActive(false);
        AudioSource.PlayClipAtPoint(shieldDownSound, transform.position);
    }

    public bool IsShielded()
    {
        return isShielded;
    }
}
