using UnityEngine;

public class GameOverDetect : MonoBehaviour
{
    public GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gameover Start");
        gameoverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // ��y�Q�R��(�B�٨SĹ�o�C��)�A�s�X gameover Canvas
        if (BallCollision.ballDestory && !WinDetect.winGame)
        {
            Debug.Log("GAMEOVER!");
            gameoverText.SetActive(true);
        }
    }
}
