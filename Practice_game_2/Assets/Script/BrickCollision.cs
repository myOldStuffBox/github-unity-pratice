using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    public int score;
    public GameObject brick;
    public GameObject brickDestorySound;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // ²y¸I¨ì¿j¶ô
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(brick);
            Instantiate(brickDestorySound);
            ScoreTextControl.score++;
        }
    }
}
