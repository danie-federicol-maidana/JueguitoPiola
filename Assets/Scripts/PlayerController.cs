using UnityEngine;

public class PlayerController : MonoBehaviour, IParalizable
{
    [SerializeField] private Animator anim;
    public float velocidad = 5f;    
    [SerializeField] private Rigidbody2D rb;

    int cereza = 10;
    int sandia = 10;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;

        anim.SetFloat("move", velocidadX * velocidad);

        Vector3 posicion = transform.position;

        transform.position = new Vector3(velocidadX + posicion.x, posicion.y, posicion.z);

        if (velocidadX < 0)
        {
            transform.localScale = new Vector3(-9, 9, 9);
        }

        if (velocidadX > 0)
        {
            transform.localScale = new Vector3(9, 9, 9);
        }
    }
    /*
    public void GetiSpeed()
    {
        velocidad = 0;
    }*/ 


    public void Paralizar() { 
        rb.linearVelocity = Vector2.zero; 
            }
}
    