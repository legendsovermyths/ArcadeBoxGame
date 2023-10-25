using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    void Start()
    {
        button.onClick.AddListener(QuitLevel);
    }
    void QuitLevel()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

    // Update is called once per frame
}

