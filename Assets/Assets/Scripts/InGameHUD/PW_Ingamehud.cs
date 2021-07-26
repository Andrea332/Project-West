using System.Collections;
using UnityEngine;


public class PW_Ingamehud : MonoBehaviour
{
    public static PW_Ingamehud ingamehud;
    public GameObject inGamehudContainer;

    private void Awake()
    {
        ingamehud = this;
    }


    public static void OpenPauseMenu()
    {
        PW_Menu.OpenPauseMenu();
    }

    public static void OpenInventory()
    {
        PW_Inventory.OpenInventory();
    }
}
