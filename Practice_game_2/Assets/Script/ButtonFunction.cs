using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    public GameObject btnSoundEffect;

    // �� Scene 1
    public void ToScence1()
    {
        Instantiate(btnSoundEffect);
        SceneManager.LoadScene(1);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // �p�ɶ��O�Ȱ��N���s�Ұʮɶ�
    }

    // �� Scene 0
    public void ToScence0()
    {
        Instantiate(btnSoundEffect);
        SceneManager.LoadScene(0);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // �p�ɶ��O�Ȱ��N���s�Ұʮɶ�
    }

    // �����C��
    public void QuitGame()
    {
        Instantiate(btnSoundEffect);
        Debug.Log("quit");
        Application.Quit();
    }
}
