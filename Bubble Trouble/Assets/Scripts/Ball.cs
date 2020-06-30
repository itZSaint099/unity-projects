using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public Rigidbody2D rb;
    public GameObject spawnBall;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if(spawnBall != null)
        {
            GameObject ball_1 = Instantiate(spawnBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball_2 = Instantiate(spawnBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball_1.GetComponent<Ball>().startForce = new Vector2(2f, 4f);
            ball_2.GetComponent<Ball>().startForce = new Vector2(-2f, 4f);
        }

        Destroy(gameObject);
    }

}
