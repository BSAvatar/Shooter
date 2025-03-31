using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float screenWidth;
    private float screenHeight;

    void Start()
    {
        screenWidth = Camera.main.orthographicSize * Camera.main.aspect;
        screenHeight = Camera.main.orthographicSize;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

        // Wrap-around left/right
        if (newPosition.x > screenWidth) newPosition.x = -screenWidth;
        if (newPosition.x < -screenWidth) newPosition.x = screenWidth;

        // Restrict movement to the bottom half of the screen
        float minY = -screenHeight;
        float maxY = 0;  // Midpoint of screen (bottom half)

        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }
}
