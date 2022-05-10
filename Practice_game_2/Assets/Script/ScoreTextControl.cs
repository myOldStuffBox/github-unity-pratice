using UnityEngine;
using UnityEngine.UI;

public class ScoreTextControl : MonoBehaviour
{
    public Text scoreText;
    static public int score;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
