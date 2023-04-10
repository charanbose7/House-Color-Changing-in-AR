using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public void OnPlayButton()
    {
        mainMenu.SetActive(false);
    }
    public void OnExitButton()
    {
        Application.Quit();
    }
}
