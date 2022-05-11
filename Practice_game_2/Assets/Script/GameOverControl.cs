using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    public GameObject gameoverText; // Game Over Text
    public GameObject winText;      // Win Text
    public GameObject restartBtn;   // 重新開始按鈕
    public GameObject menuBtn;      // 回到 Menu 按鈕

    public GameObject bricks;       // 磚塊物件

    public bool winGame;            // 是否贏得遊戲
    private int winCondition;       // 贏得遊戲條件


    // Start is called before the first frame update
    void Start()
    {
        // 將 Text & 按鈕 設為未啟動
        gameoverText.SetActive(false);
        winText.SetActive(false);
        restartBtn.SetActive(false);    
        menuBtn.SetActive(false);

        winGame = false;                // 未贏得遊戲
        winCondition = bricks.transform.childCount; // 計算磚塊總數
    }

    // Update is called once per frame
    void Update()
    {
        // 當球被摧毀(且還沒贏得遊戲)，叫出 Game Over Text
        if (BallCollision.ballDestory && !winGame)
        {
            gameoverText.SetActive(true);
            restartBtn.SetActive(true); // 顯示重新開始按鈕
            menuBtn.SetActive(true) ;   // 顯示回到 Menu 按鈕
        }

        // 贏得遊戲
        if (ScoreTextControl.score >= winCondition)
        {
            winGame = true;             // 已獲勝
            winText.SetActive(true);
            restartBtn.SetActive(true);
            menuBtn.SetActive(true);
        }
    }
}
