using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
    public void OnClickBack()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
