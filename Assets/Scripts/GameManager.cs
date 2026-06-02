using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI References")]
    public TextMeshProUGUI timerText;
    private float timeElapsed = 0f;
    private bool isPlaying = false;

    void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        isPlaying = true;
        timeElapsed = 0f;
    }

    void Update()
    {
        if (!isPlaying) return;

        timeElapsed += Time.deltaTime;

        if (timerText != null)
            timerText.text = "Time: " + Mathf.Round(timeElapsed).ToString() + "s";
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
