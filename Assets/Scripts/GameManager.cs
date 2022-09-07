using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;

    }
}
