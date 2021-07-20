using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PW_Button : MonoBehaviour, IClickable
{
    public UnityEvent myUnityEvent;
    public void OnClick()
    {
        myUnityEvent?.Invoke();
    }
}
