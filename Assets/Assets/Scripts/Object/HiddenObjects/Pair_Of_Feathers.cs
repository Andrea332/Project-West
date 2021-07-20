using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair_Of_Feathers : HiddenObject
{
    public override void OnClick()
    {
        Inventory.AddObjectToInventory(this);
    }
}
