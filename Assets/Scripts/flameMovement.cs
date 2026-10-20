using UnityEngine;

public class flameMovement : MonoBehaviour
{

    [SerializeField] private float speed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime,0 , 0);
    }
}
