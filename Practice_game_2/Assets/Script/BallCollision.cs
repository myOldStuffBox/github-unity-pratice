using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    public float platformBounceDis = 1.2f; // 控制球在平台斜向彈出角度
    static public bool ballDestory;     // 球是否已經摧毀
    public GameObject bouncingSound;
    void Start()
    {
        rb.velocity = new Vector2(0,speed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // 撞擊到平台 //
        if(collision.gameObject.name == "platform" && rb.position.y > collision.transform.position.y)
        {
            Instantiate(bouncingSound);
            float y = MoveBall(rb.position, collision.transform.position);
            rb.velocity = new Vector2(y*platformBounceDis, 1).normalized * speed;
        }

        // 撞擊到偵測牆(刪除球 & 結束遊戲)
        if(collision.gameObject.CompareTag("Detect_Ground"))
        {
            ballDestory = true;
            Destroy(rb.gameObject); // 刪除球
        }
    }


    // 計算彈出方向
    private float MoveBall( Vector2 ballPos, Vector2 pfPos )
    {
        return ballPos.x - pfPos.x; // 大於0在平台右邊，反之
    }

}
