using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket_Watch : HiddenObject
{
    public override void OnClick()
    {
        Inventory.AddObjectToInventory(this);
    }
}
