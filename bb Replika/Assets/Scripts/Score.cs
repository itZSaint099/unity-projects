using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;

    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        PinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = PinCount.ToString();
    }
}
