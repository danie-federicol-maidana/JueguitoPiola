using UnityEngine;

public class ItemInventory : MonoBehaviour
{
    public enum ItemId
    {
        Cherry,
        Lemon
    }

    [SerializeField] private ItemId itemId;

    // Permite acceder al tipo de objeto desde otros scripts
    public ItemId ItemID => itemId;
}