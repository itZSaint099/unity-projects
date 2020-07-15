using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform car;

    void FixedUpdate()
    {
        Vector3 newPosition = car.position;
        newPosition.z = -1f;
        transform.position = newPosition;
    }
}
