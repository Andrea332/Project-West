using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : HiddenObject
{
    public override void OnClick()
    {
        Inventory.AddObjectToInventory(this);
    }
}
