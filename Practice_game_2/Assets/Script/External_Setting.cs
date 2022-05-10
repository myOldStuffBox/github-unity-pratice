using UnityEngine;

/// <summary>
///此 Script 用來做球體額外設定
/// </summary>
public class External_Setting : MonoBehaviour
{

    public Rigidbody2D ballRb;

    // Update is called once per frame
    void Update()
    {
        PreventInfinitBouncing();
    }

    // 防止球體陷入無限反彈
    void PreventInfinitBouncing()
    {
        if (ballRb.velocity.y == 0)
        {
            ballRb.velocity = new Vector2(ballRb.velocity.x, -0.1f);
        }
    }

}
