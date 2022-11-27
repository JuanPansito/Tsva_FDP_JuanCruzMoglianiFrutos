using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject pauseCanvas;

    public bool isPause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPause= !isPause;
        player.SetActive(!isPause);
        pauseCanvas.SetActive(isPause);
    }
}
