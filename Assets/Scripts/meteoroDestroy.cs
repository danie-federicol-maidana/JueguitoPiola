using UnityEngine;

public class meteoroDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D meteoro)
    {
        for (int i = 0; i <= 4; i++)
            if (meteoro.gameObject.CompareTag("meteoro"))
        {
            Destroy(gameObject);
            Destroy(gameObject, 1f);
        }
    }
}
