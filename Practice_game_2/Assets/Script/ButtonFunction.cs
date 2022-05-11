using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    // �� Scene 1
    public void ToScence1()
    {
        SceneManager.LoadScene(1);
        BallCollision.ballDestory = false;
    }

    // �� Scene 0
    public void ToScence0()
    {
        SceneManager.LoadScene(0);
        BallCollision.ballDestory = false;
    }

    // �����C��
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
