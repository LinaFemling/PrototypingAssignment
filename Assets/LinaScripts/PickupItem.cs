using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{

    public ItemType type;

    public void Consume(PlayerMovement player)
    {
        player.GetInventory().AddItem(new Item { itemType = type, amount = 1 });
        player.GetUIInventory().RefreshInventoryItems();
        gameObject.tag = "Untagged";
        Destroy(gameObject);
    }
}
