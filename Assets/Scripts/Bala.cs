
using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IParalizable objetivo = collision.gameObject.GetComponent<IParalizable>();

        if (objetivo != null)
        {
            objetivo.Paralizar();
        }

        //Destroy(gameObject);
    }
}

