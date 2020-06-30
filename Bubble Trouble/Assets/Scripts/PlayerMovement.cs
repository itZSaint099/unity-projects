using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;

    private float movement = 0f;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            // GAME OVER
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
