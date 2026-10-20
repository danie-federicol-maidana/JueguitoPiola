using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Inventory inventory;

    [SerializeField] private TextMeshProUGUI tFruit;
    [SerializeField] private int fruit = 10;
    [SerializeField] private Image barraVida;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ItemInventory item = collision.gameObject.GetComponent<ItemInventory>();

        if (item != null)
        {
            if (inventory.CheckMaxItem(item.ItemID))
            {
                inventory.AddItem(item.ItemID, 1);

                Destroy(collision.gameObject);
            }
        }
    }
}