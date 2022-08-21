using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Settings()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void ChooseCountry()
    {
        SceneManager.LoadScene(1);
    }


    public void BackMain()
    {
        SceneManager.LoadScene(0);
    }

}

