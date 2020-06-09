using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowMoFactor = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
        Debug.Log(Time.timeScale + "," + Time.fixedDeltaTime);
        Debug.Log("After restart" + Time.fixedDeltaTime);
    }

    public void RestartGame()
    {
        Time.fixedDeltaTime = Time.fixedUnscaledDeltaTime;
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        //Debug.Log("QUIT");
        Application.Quit();
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowMoFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowMoFactor;

        yield return new WaitForSeconds(1f / slowMoFactor);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowMoFactor;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
