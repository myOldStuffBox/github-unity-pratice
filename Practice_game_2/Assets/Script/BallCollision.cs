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

    // 計算彈出方向
    private float MoveBall( Vector2 ballPos, Vector2 pfPos )
    {
        return ballPos.x - pfPos.x; // 大於0在平台右邊，反之
    }

}
