using UnityEngine;

public class GameOverDetect : MonoBehaviour
{
    public GameObject gameoverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gameover Start");
        gameoverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 當球被摧毀(且還沒贏得遊戲)，叫出 gameover Canvas
        if (BallCollision.ballDestory && !WinDetect.winGame)
        {
            Debug.Log("GAMEOVER!");
            gameoverCanvas.SetActive(true);
        }
    }
}
