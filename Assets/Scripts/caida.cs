using UnityEngine;

public class caida : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private BoxCollider2D boxCollider;
    void Start()
    {
        boxCollider =  GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -20 * Time.deltaTime, 0);
    }

    
}
