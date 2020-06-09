using UnityEngine;

public class PlayerMovementTouch : MonoBehaviour
{
    public float speedTouch = 0.2f;
    public float mapWidthTouch = 2.16f;
    //private Vector2 mousePos;
    private Vector2 touchPos;
    private Rigidbody2D rbTouch;
    //private PlayerMovementTouch pb;

    // Start is called before the first frame update
    void Start()
    {
        rbTouch = GetComponent<Rigidbody2D>();
        Debug.Log(rbTouch.position);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePos.x = Mathf.Clamp(mousePos.x, -mapWidthTouch, mapWidthTouch);
        //mousePos.y = 0f;
        //Vector2 newPosition = Vector2.MoveTowards(transform.position, mousePos, Time.fixedDeltaTime * speedTouch);
        //rbTouch.MovePosition(newPosition);

        //float x = mousePos.x * Time.fixedDeltaTime * speedTouch;
        //Debug.Log("Clamped" + Input.GetAxis("Mouse X"));
        //float x = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * speedTouch;
        //Debug.Log(Camera.main.ScreenToWorldPoint(x));
        //mousePos.x = Mathf.Clamp(mousePos.x, -mapWidthTouch, mapWidthTouch);
        //rbTouch.transform.position = rbTouch.transform.position + new Vector3(mousePos.x, 0.0f, 0.0f);
        //Vector2 newPos = rbTouch.position + (Vector2.right * mousePos.x);
        //rbTouch.MovePosition(newPos);


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.x = Mathf.Clamp(touchPos.x, -mapWidthTouch, mapWidthTouch);
            touchPos.y = 0f;
            Vector2 touchPosition = Vector2.MoveTowards(transform.position, touchPos, Time.fixedDeltaTime * speedTouch);
            rbTouch.MovePosition(touchPosition);
            //touchPosition.y = touchPosition.z = 0f;
            //touchPosition.x = Mathf.Clamp(touchPosition.x, -mapWidth, mapWidth);
            //rb.MovePosition(touchPosition);
            //rb.transform.position = new Vector2(touchPosition.x,touchPosition.y);
        }
    }

    void OnCollisionEnter2D()
    {
        //Debug.Log("hit" + Time.fixedDeltaTime + "Cor" + Camera.main.ScreenToWorldPoint(Input.mousePosition));
        FindObjectOfType<GameManager>().EndGame();
    }
}
