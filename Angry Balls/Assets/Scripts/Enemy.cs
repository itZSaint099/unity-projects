using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;

    public float health = 4f;

    public static int EnemiesAlive = 0;

    void Start()
    {
        EnemiesAlive++;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        float relVelocity = collisionInfo.relativeVelocity.magnitude;

        if (relVelocity > health)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        
        EnemiesAlive--;
        if(EnemiesAlive<= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Restart");
        }

        Destroy(gameObject);
    }
}
