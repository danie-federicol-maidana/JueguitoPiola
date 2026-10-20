using UnityEngine;

public class Arrow : MonoBehaviour
{
    float speed = 15f;
    [SerializeField] private GameObject arrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(arrow, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
       // Destroy(arrow, 1f);

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {

        iDamageable enemy = collider.gameObject.GetComponent<iDamageable>();
        if (enemy != null)
        {
            enemy.GetDamage();
        }

        IParalized paralizable = collider.gameObject.GetComponent<IParalized>();
        if (paralizable != null)
        {
            paralizable.GetParalize();
        }
    }

}
