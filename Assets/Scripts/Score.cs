using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text score;
    private int temp;
    void Update()
    {
        temp = ((int)Player.position.z + 120) / 2;
        score.text = temp.ToString();
    }
}
