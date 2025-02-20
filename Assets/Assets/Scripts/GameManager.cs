using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 싱글튼 만들기
    [SerializeField] private GameObject gameStartCanvas;
    [SerializeField] private GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        Time.timeScale = 0;
        gameStartCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        gameStartCanvas.SetActive(false);
    }
    // Update is called once per frame
    public void GameOver()
    {
        gameStartCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
