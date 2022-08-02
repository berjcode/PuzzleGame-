using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject pauseMenuUI;
  

    void pause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }
}
