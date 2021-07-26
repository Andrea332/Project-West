using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PW_Menu : MonoBehaviour
{
    public static PW_Menu menu;
    public GameObject menuContainer;

    private void Awake()
    {
        menu = this;
    }
    public static void OpenPauseMenu()
    {
        menu.menuContainer.SetActive(true);
    }
    public static void OnPlay()
    {
        menu.menuContainer.SetActive(false);
    }

    public static void OnQuit()
    {
        Application.Quit();
    }
}
