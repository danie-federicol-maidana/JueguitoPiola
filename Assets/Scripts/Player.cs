using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int damage = 2;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
}

    