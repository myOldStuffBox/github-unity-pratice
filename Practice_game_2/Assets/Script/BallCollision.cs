using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    void Start()
    {
        rb.velocity = new Vector2(0,speed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "platform")
        {
            float y = MoveBall(rb.position, collision.transform.position);
            rb.velocity = (new Vector2(y, 1).normalized) * speed;
        }
    }

    // �p��u�X��V
    private float MoveBall( Vector2 ballPos, Vector2 pfPos )
    {
        return ballPos.x - pfPos.x; // �j��0�b���x�k��A�Ϥ�
    }

}
