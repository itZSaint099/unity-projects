using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public float movementSpeed = 1500f;
    public float rotationSpeed = 15f;

    public Rigidbody2D rb;

    private float movement;
    private float rotation;

    // Update is called once per frame
    void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * movementSpeed;
        rotation = -Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if(movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor2D = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000f };

            backWheel.motor = motor2D;
            frontWheel.motor = motor2D;
        }

        rb.AddTorque(rotation * rotationSpeed * Time.fixedDeltaTime);
    }
}
