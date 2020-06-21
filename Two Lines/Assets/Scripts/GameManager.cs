using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;
    public void EngGame()
    {
        if (hasEnded)
            return;

        hasEnded = true;
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver ()
    {
        Debug.Log("Game Over");
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
