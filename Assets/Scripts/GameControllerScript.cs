using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public string currentState;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == "flappy") 
        {
            canvas.SetActive(true);
        } else 
        {
            canvas.SetActive(false);
        }
    }
}
