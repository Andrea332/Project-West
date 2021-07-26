using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HiddenObject : MonoBehaviour, IClickable
{
    public SpriteRenderer spriteRenderer;
    public bool inInventory;

    public abstract void OnClick();

}
