using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float pinSpeed = 20f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * pinSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            // collision.GetComponent<Rotator>().rotatorSpeed *= -1;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            // END GAME
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
