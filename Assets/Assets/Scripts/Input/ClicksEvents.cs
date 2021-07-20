using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksEvents : MonoBehaviour
{

    public Text debugClickTesto;
    public Text debugPosizioneClick;
    public int numClick;
    public LayerMask clickColliderLayers;

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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 0, clickColliderLayers);

      
        if (hit.collider != null)
        {
            print(hit.collider.name);
            if (hit.collider.TryGetComponent(out IClickable clickable))
            {
                clickable.OnClick();
            }
        }
    }
}
