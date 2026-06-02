using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject startPanel;
    public GameObject gamePanel;

    void Awake()
    {
        Time.timeScale = 0f;
        startPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    public void OnPlayButtonPressed()
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(true);
        Time.timeScale = 1f;
        GameManager.Instance.StartGame();
    }
}
