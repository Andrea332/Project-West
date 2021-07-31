using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CursorController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text debugClickTesto;
    public Text debugPosizioneClick;
    public SpriteRenderer level;
    public int numClick;
    public float controllerCursorSpeed;
    public float mouseCursorSpeed;
    private Vector3 mousePosAtControllerSwitch;
    public Vector2 cursorPos;
    public RectTransform canvasRectTransform;
    public RectTransform cursorRectTransform;
    float shiftresolutionx;

    void Start()
    {
        Cursor.visible = false;
        float screenRatioX = 9 * Screen.width / Screen.height;
        float resolutionx = 16 * Screen.width / screenRatioX;
        shiftresolutionx = (Screen.width - resolutionx) / 2 ;
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


        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && Input.mousePosition != mousePosAtControllerSwitch)
        {
            cursorPos = Input.mousePosition * mouseCursorSpeed;
            mousePosAtControllerSwitch = Input.mousePosition;
        }
        else
        {
            cursorPos += new Vector2(Input.GetAxis("Horizontal") * controllerCursorSpeed, Input.GetAxis("Vertical") * controllerCursorSpeed);
        }
       
        cursorPos.x = Mathf.Clamp(cursorPos.x, shiftresolutionx, Screen.width - shiftresolutionx);
        cursorPos.y = Mathf.Clamp(cursorPos.y, 0, Screen.height);

        /*Vector3 posizione = Camera.main.ScreenToWorldPoint(cursorPos);
        posizione = new Vector3(posizione.x, posizione.y, 0);*/
        cursorRectTransform.transform.position = cursorPos;

        if (Input.GetButtonDown("Fire1"))
        {
            numClick++;
            debugPosizioneClick.text = "Posizione " + cursorRectTransform.transform.position;
            Raycast();
        }
    }

    public void Raycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.zero, 0);
        RaycastHit2D hit2 = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(gameObject.transform.position), Vector2.zero, 0);

        if (hit.transform != null)
        {
            print(hit.transform.name);
            debugClickTesto.text = "Cliccato " + hit.transform.name;
            //print(hit.collider.name);
            if (hit.collider.TryGetComponent(out Button button))
            {
                button.onClick.Invoke();
            }
            return;
        }
        if (hit2.transform != null)
        {
            print(hit2.transform.name);
            debugClickTesto.text = "Cliccato " + hit2.transform.name;
            //print(hit.collider.name);
            if (hit2.collider.TryGetComponent(out Button button))
            {
                button.onClick.Invoke();
            }
            return;
        }
    }
}
