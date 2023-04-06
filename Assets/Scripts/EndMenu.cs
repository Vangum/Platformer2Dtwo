using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Screen");
        //Application.Quit();
    }
}
