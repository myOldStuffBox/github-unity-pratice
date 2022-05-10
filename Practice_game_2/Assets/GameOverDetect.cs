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
        // ��y�Q�R��(�B�٨SĹ�o�C��)�A�s�X gameover Canvas
        if (BallCollision.ballDestory && !WinDetect.winGame)
        {
            Debug.Log("GAMEOVER!");
            gameoverCanvas.SetActive(true);
        }
    }
}
