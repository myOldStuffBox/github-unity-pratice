using UnityEngine;

public class BackgroundMusicControl : MonoBehaviour
{
    public GameObject backgroundMusic;
    private GameObject bgm = null;
    void Start()
    {
        // 檢查有無背景音樂物件
        bgm = GameObject.FindGameObjectWithTag("Background Music");
        if(bgm == null) Instantiate(backgroundMusic);
    }

}
