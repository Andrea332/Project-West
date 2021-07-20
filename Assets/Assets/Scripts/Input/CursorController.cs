using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorController : MonoBehaviour
{
    //VARIABILE USATE PER IL SISTEMA MANUALE DI CAMBIO DI INPUT TRA MOUSE/TOUCH E CONTROLLER
    //public bool usingMouseInput; 

    public float controllerCursorSpeed;
    public float mouseCursorSpeed;
    private Vector3 mousePosAtControllerSwitch;
    public Vector2 cursorPos;
    public GameObject Cursore;
    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        /// <summary>SCRIPT UTILIZZATO PER IL SISTEMA MANUALE DI CAMBIO INPUT TRA MOUSE/TOUCH E CONTROLLER
        /*
         * if (usingMouseInput)
        {
            cursorPos = Input.mousePosition * mouseCursorSpeed;
        }
        else
        {
            cursorPos += new Vector2(Input.GetAxis("Horizontal") * controllerCursorSpeed, Input.GetAxis("Vertical") * controllerCursorSpeed);           
        }

        cursorPos.x = Mathf.Clamp(cursorPos.x, 0, Screen.width - 1);
        cursorPos.y = Mathf.Clamp(cursorPos.y, 0, Screen.height - 1);

        Vector3 posizione = Camera.main.ScreenToWorldPoint(cursorPos);
        posizione = new Vector3(posizione.x, posizione.y, 0);
        Cursore.transform.position = posizione;
        */
        /// <summary>

        if (Input.GetAxis("Horizontal") == 0 &&  Input.GetAxis("Vertical") == 0 && Input.mousePosition != mousePosAtControllerSwitch)
        {
            cursorPos = Input.mousePosition * mouseCursorSpeed;
            mousePosAtControllerSwitch = Input.mousePosition;           
        }
        else
        {
            cursorPos += new Vector2(Input.GetAxis("Horizontal") * controllerCursorSpeed, Input.GetAxis("Vertical") * controllerCursorSpeed);
        }

        cursorPos.x = Mathf.Clamp(cursorPos.x, 0, Screen.width - 1);
        cursorPos.y = Mathf.Clamp(cursorPos.y, 0, Screen.height - 1);

        Vector3 posizione = Camera.main.ScreenToWorldPoint(cursorPos);
        posizione = new Vector3(posizione.x, posizione.y, Cursore.transform.position.z);
        Cursore.transform.position = posizione;

    }
}
