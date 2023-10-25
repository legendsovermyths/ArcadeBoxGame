using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{


    // Update is called once per frame
    bool gameEnded = false;
    public float restartTime = 3f;
    public GameObject LevelCompletionPanel;

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;

        }
        Invoke("RestartGame", restartTime);
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        LevelCompletionPanel.SetActive(true);
    }
}
