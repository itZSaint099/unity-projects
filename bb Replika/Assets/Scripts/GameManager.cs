using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    public Animator rotatorAnimator;
    public Score score;

    public void EndGame()
    {
        if (gameEnded)
        {
            return;
        }
        gameEnded = true;

        animator.SetTrigger("EndGame");
        rotatorAnimator.SetTrigger("EndGame");

        spawner.enabled = false;
        rotator.enabled = false;
        score.enabled = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
