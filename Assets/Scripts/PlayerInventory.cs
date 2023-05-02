using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public GameManager myGM;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
           Inventoryactivate();
        }
    }
    void Inventoryactivate()
    {
        myGM.Activeinventory();
    }
}
