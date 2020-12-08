using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksEvents : MonoBehaviour
{

    public Text debugClickTesto;
    public Text debugPosizioneClick;
    public int numClick;
    private void Start()
    {
        debugClickTesto = GameObject.Find("DebugClick").GetComponent<Text>();
        debugPosizioneClick = GameObject.Find("DebugPosizioneClick").GetComponent<Text>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            numClick++;
            debugClickTesto.text = "Cliccato " + numClick;
            debugPosizioneClick.text = "Posizione " + gameObject.transform.position;
            Raycast();
        }
    }

    public void Raycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 0);

        if (hit.collider != null)
        {
            print("Ho Cliccato sull'oggetto " + hit.collider.name);
        }
    }
}
