using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1.0f;
    // public float jumpForce = 10f;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D)) rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
        if (Input.GetKey(KeyCode.A)) rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
        // if (Input.GetKey(KeyCode.Space)) rb.AddForce( new Vector2(0f,jumpForce) );
    }
}
