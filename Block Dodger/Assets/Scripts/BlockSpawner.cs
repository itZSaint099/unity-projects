using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;

    private Score score;

    int c = 0;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Start is called before the first frame update
    void Update()
    {

        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            c++;
            score.wave.text = c.ToString();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
