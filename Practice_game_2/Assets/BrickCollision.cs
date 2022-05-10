using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    public GameObject brick;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(brick);
        }
    }
}
