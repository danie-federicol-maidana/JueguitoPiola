using UnityEngine;

public class MoveArrowRight : MonoBehaviour
{
    [SerializeField] private int speed = 15;
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
        
}
