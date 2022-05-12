using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    public GameObject gameoverText; // Game Over Text
    public GameObject winText;      // Win Text
    public GameObject restartBtn;   // 重新開始按鈕
    public GameObject menuBtn;      // 回到 Menu 按鈕
    public GameObject stopUI;       // 停止時的 UI

    public GameObject bricks;       // 磚塊物件
    public GameObject gameOverSound;
    public GameObject winSound;

    private int winCondition;       // 贏得遊戲條件
    public bool winGame;            // 是否贏得遊戲
    public bool loseGame;           // 是否 Game Over
    private bool stop;              // 是否暫停遊戲

    // ================================================================================

    // Start is called before the first frame update
    void Start()
    {
        // 將 Text & 按鈕 設為未啟動
        gameoverText.SetActive(false);
        winText.SetActive(false);
        restartBtn.SetActive(false);    
        menuBtn.SetActive(false);
        stopUI.SetActive(false);

        winGame = false;                // 未贏得遊戲
        loseGame = false;               // 未輸遊戲
        stop = false;                   // 未暫停遊戲
        winCondition = bricks.transform.childCount; // 計算磚塊總數
    }


    void Update()
    {
        // 當球被摧毀(且還沒贏得遊戲)，叫出 Game Over Text
        if (BallCollision.ballDestory && !winGame ) LoseGame();
        // 贏得遊戲 Win Text
        if (ScoreTextControl.score >= winCondition ) WinGame();


        // 按下 ESC 暫停遊戲 // 解除暫停
        if (Input.GetKeyUp(KeyCode.Escape) && !stop) StopGame(true);
        else if (Input.GetKeyUp(KeyCode.Escape) && stop) StopGame(false);
    }


    // ================================================================================
    void LoseGame()
    {
        loseGame = true;            // 以輸
        gameoverText.SetActive(true);
        restartBtn.SetActive(true); // 顯示重新開始按鈕
        menuBtn.SetActive(true);   // 顯示回到 Menu 按鈕
        Instantiate(gameOverSound);
    }
    void WinGame()
    {
        winGame = true;             // 已獲勝
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
