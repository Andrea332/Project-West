using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenObject : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool inInventory;

    public void OnButtonClick()
    {
        PW_Inventory.AddObjectToInventory(this);
    }
}
