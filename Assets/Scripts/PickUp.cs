using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUp : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.inventorySlots.Length ; i++)
            {
                if (inventory.inventoryFull[i] == false)
                {
                    inventory.inventoryFull[i] = true;
                    Instantiate(itemButton, inventory.inventorySlots[i].transform,false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
