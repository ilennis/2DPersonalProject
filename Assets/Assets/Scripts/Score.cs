using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    // Start is called before the first frame update

    [SerializeField] private Text currentScore;
    [SerializeField] private Text bestScore;

    private int score;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    void Start()
    {
        currentScore.text = score.ToString();
        bestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            bestScore.text = score.ToString();
        }
    }
    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHighScore();

    }
}
