using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PW_Inventory : MonoBehaviour
{
    public static PW_Inventory inventory;
    public GameObject inventoryContainer;
    public Text inventoryUpdateText;
    public List<HiddenObject> hiddenObjectsInInventory;
    public List<Transform> hiddenObjectsInventoryPositions;

    private void Awake()
    {
        inventory = this;
    }

    private void Start()
    {
        inventory.StopAllCoroutines();
        inventory.StartCoroutine(inventory.InventoryUpdateText(""));
    }
    public static void AddObjectToInventory(HiddenObject hiddenObject)
    {
        if (inventory.hiddenObjectsInInventory.Count < inventory.hiddenObjectsInventoryPositions.Count)
        {
            if (!hiddenObject.inInventory)
            {
                inventory.hiddenObjectsInInventory.Add(hiddenObject);
                Image image = inventory.hiddenObjectsInventoryPositions[inventory.hiddenObjectsInInventory.Count - 1].GetComponent<Image>();
                image.sprite = hiddenObject.spriteRenderer.sprite;
                image.color = new Color32(255, 255, 255, 255);
                hiddenObject.gameObject.SetActive(false);

                hiddenObject.inInventory = true;
            }
        }
        else
        {
            inventory.StopAllCoroutines();
            inventory.StartCoroutine(inventory.InventoryUpdateText("Inventory capacity limit reached"));
        }
    }

    public static void OpenInventory()
    {
        inventory.inventoryContainer.SetActive(true);
    }

    public static void CloseInventory()
    {
        inventory.inventoryContainer.SetActive(false);
    }

    public IEnumerator InventoryUpdateText(string textToUse)
    {
        inventory.inventoryUpdateText.text = textToUse;
        yield return new WaitForSeconds(3);
        inventory.inventoryUpdateText.text = "";
    }
}
