using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    // 到 Scene 1
    public void ToScence1()
    {
        SceneManager.LoadScene(1);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // 如時間是暫停就重新啟動時間
    }

    // 到 Scene 0
    public void ToScence0()
    {
        SceneManager.LoadScene(0);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // 如時間是暫停就重新啟動時間
    }

    // 結束遊戲
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
