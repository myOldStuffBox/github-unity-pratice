using UnityEngine;

public class BackgroundMusicControl : MonoBehaviour
{
    public GameObject backgroundMusic;
    private GameObject bgm = null;
    void Start()
    {
        // �ˬd���L�I�����֪���
        bgm = GameObject.FindGameObjectWithTag("Background Music");
        if(bgm == null) Instantiate(backgroundMusic);
    }

}
