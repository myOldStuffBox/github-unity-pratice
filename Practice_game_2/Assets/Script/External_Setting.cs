using UnityEngine;

/// <summary>
///�� Script �ΨӰ��y���B�~�]�w
/// </summary>
public class External_Setting : MonoBehaviour
{

    public Rigidbody2D ballRb;

    // Update is called once per frame
    void Update()
    {
        PreventInfinitBouncing();
    }

    // ����y�鳴�J�L���ϼu
    void PreventInfinitBouncing()
    {
        if (ballRb.velocity.y == 0)
        {
            ballRb.velocity = new Vector2(ballRb.velocity.x, -0.1f);
        }
    }

}
