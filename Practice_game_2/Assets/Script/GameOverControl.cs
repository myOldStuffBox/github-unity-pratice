using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    public GameObject gameoverText; // Game Over Text
    public GameObject winText;      // Win Text
    public GameObject restartBtn;   // ���s�}�l���s
    public GameObject menuBtn;      // �^�� Menu ���s

    public GameObject bricks;       // �j������

    public bool winGame;            // �O�_Ĺ�o�C��
    private int winCondition;       // Ĺ�o�C������


    // Start is called before the first frame update
    void Start()
    {
        // �N Text & ���s �]�����Ұ�
        gameoverText.SetActive(false);
        winText.SetActive(false);
        restartBtn.SetActive(false);    
        menuBtn.SetActive(false);

        winGame = false;                // ��Ĺ�o�C��
        winCondition = bricks.transform.childCount; // �p��j���`��
    }

    // Update is called once per frame
    void Update()
    {
        // ��y�Q�R��(�B�٨SĹ�o�C��)�A�s�X Game Over Text
        if (BallCollision.ballDestory && !winGame)
        {
            gameoverText.SetActive(true);
            restartBtn.SetActive(true); // ��ܭ��s�}�l���s
            menuBtn.SetActive(true) ;   // ��ܦ^�� Menu ���s
        }

        // Ĺ�o�C��
        if (ScoreTextControl.score >= winCondition)
        {
            winGame = true;             // �w���
            winText.SetActive(true);
            restartBtn.SetActive(true);
            menuBtn.SetActive(true);
        }
    }
}
