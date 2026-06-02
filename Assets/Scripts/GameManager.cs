using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
   [Header("UI References")]
    public TextMeshProUGUI timerText;
    private float timeElapsed = 0f;

    void Update()
    {
        // Increment the timer via engine delta time
        timeElapsed += Time.deltaTime;
        
        // Update the UI if the reference is assigned
        if(timerText != null)
        {
            timerText.text = "Time: " + Mathf.Round(timeElapsed).ToString() + "s";
        }
    }

    // This method will be triggered by your Restart Button
    public void RestartLevel()
    {
        // Force the engine to reload the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
