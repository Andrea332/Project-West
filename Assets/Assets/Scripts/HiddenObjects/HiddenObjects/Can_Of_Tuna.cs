using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_Of_Tuna : HiddenObject
{
    public override void OnClick()
    {
        PW_Inventory.AddObjectToInventory(this);
    }
}
