using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetect : MonoBehaviour
{
    static public bool winGame;     // 使否贏得遊戲
    public int winCondition;        
    public GameObject winCanvas;
    public GameObject bricks;
    private void Start()
    {
        winCanvas.SetActive(false);     // UI 先設為 false
        winGame = false;                // 未贏得比賽
        winCondition = bricks.transform.childCount; // 計算場上的 bricks 數量
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreTextControl.score >= winCondition)
        {
            winGame = true;
            winCanvas.SetActive(true);
        }
    }
}
