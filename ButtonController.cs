using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    public GameObject square;
    //MainMenu
    public void BackMain()
    {
        SceneManager.LoadScene(1);
    }


    
    public void whenButtonClicked()
    {
        if(square.activeInHierarchy == true)
            square.SetActive(false);
        else
            square.SetActive(true);
    }
    


}
