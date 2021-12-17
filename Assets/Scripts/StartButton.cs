using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
