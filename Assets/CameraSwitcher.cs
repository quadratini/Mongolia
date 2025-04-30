using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    public GameObject cam1, cam2;
    
    private void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}