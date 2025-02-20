using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public Text bestScoreText;
    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);
        bestScoreText.text = bestScore.ToString();
    }
}
