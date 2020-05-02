using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    public float gravityScaleIncrements = 20f;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleIncrements;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
