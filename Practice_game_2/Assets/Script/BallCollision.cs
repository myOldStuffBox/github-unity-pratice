using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    public float platformBounceDis = 1.2f; // ����y�b���x�צV�u�X����
    static public bool ballDestory;     // �y�O�_�w�g�R��
    public GameObject bouncingSound;
    void Start()
    {
        rb.velocity = new Vector2(0,speed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // �����쥭�x //
        if(collision.gameObject.name == "platform" && rb.position.y > collision.transform.position.y)
        {
            Instantiate(bouncingSound);
            float y = MoveBall(rb.position, collision.transform.position);
            rb.velocity = new Vector2(y*platformBounceDis, 1).normalized * speed;
        }

        // �����찻����(�R���y & �����C��)
        if(collision.gameObject.CompareTag("Detect_Ground"))
        {
            ballDestory = true;
            Destroy(rb.gameObject); // �R���y
        }
    }


    // �p��u�X��V
    private float MoveBall( Vector2 ballPos, Vector2 pfPos )
    {
        return ballPos.x - pfPos.x; // �j��0�b���x�k��A�Ϥ�
    }

}
