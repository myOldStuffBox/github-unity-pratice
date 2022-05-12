using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    public GameObject btnSoundEffect;

    // 到 Scene 1
    public void ToScence1()
    {
        Instantiate(btnSoundEffect);
        SceneManager.LoadScene(1);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // 如時間是暫停就重新啟動時間
    }

    // 到 Scene 0
    public void ToScence0()
    {
        Instantiate(btnSoundEffect);
        SceneManager.LoadScene(0);
        BallCollision.ballDestory = false;
        if (Time.timeScale == 0) Time.timeScale = 1;    // 如時間是暫停就重新啟動時間
    }

    // 結束遊戲
    public void QuitGame()
    {
        Instantiate(btnSoundEffect);
        Debug.Log("quit");
        Application.Quit();
    }
}
