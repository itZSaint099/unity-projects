using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public void EndGame()
    {
        if (gameEnded)
        {
            return;
        }
        gameEnded = true;

        spawner.enabled = false;
        rotator.enabled = false;
    }
}
