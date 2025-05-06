using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public GameObject openWorldUI;
    public GameObject flappyBirdUI;
    public GameObject openWorldController;
    public GameObject flappyBirdController;
    public Camera mainCamera;

    Vector3 flappyBirdCameraPosition = new Vector3(500, 10, -10);
    Vector3 openWorldCameraPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8))
        {
            EnterFlappyBirdGame();
        }
    }

    void EnterFlappyBirdGame()
    {
        openWorldCameraPosition = mainCamera.transform.position;
        mainCamera.transform.position = flappyBirdCameraPosition;

        openWorldUI.SetActive(false);
        flappyBirdUI.SetActive(true);

        openWorldController.SetActive(false);
        flappyBirdController.SetActive(true);
    }

    void ExitFlappyBirdGame()
    {
        mainCamera.transform.position = openWorldCameraPosition;

        openWorldUI.SetActive(true);
        flappyBirdUI.SetActive(false);

        openWorldController.SetActive(true);
        flappyBirdController.SetActive(false);
    }
}
