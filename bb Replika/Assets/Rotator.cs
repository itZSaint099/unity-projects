using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotatorSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotatorSpeed * Time.deltaTime);
    }
}
