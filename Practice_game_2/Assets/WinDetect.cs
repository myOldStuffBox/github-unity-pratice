using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetect : MonoBehaviour
{
    static public bool winGame;     // �ϧ_Ĺ�o�C��
    public int winCondition;        
    public GameObject winCanvas;
    public GameObject bricks;
    private void Start()
    {
        winCanvas.SetActive(false);     // UI ���]�� false
        winGame = false;                // ��Ĺ�o����
        winCondition = bricks.transform.childCount; // �p����W�� bricks �ƶq
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
