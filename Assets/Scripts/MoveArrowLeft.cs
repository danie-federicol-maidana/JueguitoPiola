using UnityEngine;

public class MoveArrowLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-15 * Time.deltaTime, 0, 0); 
    }
}
