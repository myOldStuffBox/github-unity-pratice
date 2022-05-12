using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    public GameObject gameoverText; // Game Over Text
    public GameObject winText;      // Win Text
    public GameObject restartBtn;   // ���s�}�l���s
    public GameObject menuBtn;      // �^�� Menu ���s
    public GameObject stopUI;       // ����ɪ� UI

    public GameObject bricks;       // �j������
    public GameObject gameOverSound;
    public GameObject winSound;

    private int winCondition;       // Ĺ�o�C������
    public bool winGame;            // �O�_Ĺ�o�C��
    public bool loseGame;           // �O�_ Game Over
    private bool stop;              // �O�_�Ȱ��C��

    // ================================================================================

    // Start is called before the first frame update
    void Start()
    {
        // �N Text & ���s �]�����Ұ�
        gameoverText.SetActive(false);
        winText.SetActive(false);
        restartBtn.SetActive(false);    
        menuBtn.SetActive(false);
        stopUI.SetActive(false);

        winGame = false;                // ��Ĺ�o�C��
        loseGame = false;               // ����C��
        stop = false;                   // ���Ȱ��C��
        winCondition = bricks.transform.childCount; // �p��j���`��
    }


    void Update()
    {
        // ��y�Q�R��(�B�٨SĹ�o�C��)�A�s�X Game Over Text
        if (BallCollision.ballDestory && !winGame ) LoseGame();
        // Ĺ�o�C�� Win Text
        if (ScoreTextControl.score >= winCondition ) WinGame();


        // ���U ESC �Ȱ��C�� // �Ѱ��Ȱ�
        if (Input.GetKeyUp(KeyCode.Escape) && !stop) StopGame(true);
        else if (Input.GetKeyUp(KeyCode.Escape) && stop) StopGame(false);
    }


    // ================================================================================
    void LoseGame()
    {
        loseGame = true;            // �H��
        gameoverText.SetActive(true);
        restartBtn.SetActive(true); // ��ܭ��s�}�l���s
        menuBtn.SetActive(true);   // ��ܦ^�� Menu ���s
        Instantiate(gameOverSound);
    }
    void WinGame()
    {
        winGame = true;             // �w���
        winText.SetActive(true);
        restartBtn.SetActive(true);
        menuBtn.SetActive(true);
        Instantiate(winSound);
    }

    void StopGame( bool isStop)
    {
        if(isStop) Time.timeScale = 0;
        if (!isStop) Time.timeScale = 1;
        stopUI.SetActive(isStop);
        stop = isStop;
    }
}
