using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PW_Menu : MonoBehaviour
{
    public GameObject MenuContainer;
    public void OnPlay()
    {
        MenuContainer.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
