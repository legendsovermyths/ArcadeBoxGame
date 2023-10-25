using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(StartLevel);
    }

    // Update is called once per frame
    void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
