using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory inventory;
    public TextMesh inventoryUpdateText;
    public List<HiddenObject> hiddenObjectsInInventory;
    public List<Transform> hiddenObjectsInventoryPositions;
    private void Awake()
    {
        inventory = this;
    }
    public static void AddObjectToInventory(HiddenObject hiddenObject)
    {
        if (inventory.hiddenObjectsInInventory.Count < inventory.hiddenObjectsInventoryPositions.Count)
        {
            if (!hiddenObject.inInventory)
            { 
                inventory.hiddenObjectsInInventory.Add(hiddenObject);
                hiddenObject.transform.position = inventory.hiddenObjectsInventoryPositions[inventory.hiddenObjectsInInventory.Count - 1].position;
                hiddenObject.spriteRenderer.sortingLayerName = "Inventory";
                hiddenObject.spriteRenderer.sortingOrder = 1;
                hiddenObject.inInventory = true;
            }
        }
        else
        {
            inventory.StopAllCoroutines();
            inventory.StartCoroutine(inventory.InventoryUpdateText());
        }
    }

    public IEnumerator InventoryUpdateText()
    {
        inventory.inventoryUpdateText.text = "Inventory capacity limit reached";
        yield return new WaitForSeconds(3);
        inventory.inventoryUpdateText.text = "";
    }
}
