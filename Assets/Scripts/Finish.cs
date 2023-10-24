using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    public Manager gameManager;
    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
