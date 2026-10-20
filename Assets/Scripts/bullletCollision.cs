using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bullletCollision : MonoBehaviour
{


    [SerializeField] private int speed;
    [SerializeField] private int health = 10;
    [SerializeField] private Image   barraSalud;
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI thealth;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health -= collision.gameObject.GetComponent<Player>().Damage;
            thealth.text = health.ToString();
            barraSalud.fillAmount = health / 10f;
            if (health == 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                Derrota();
            }
        }
    }
    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
    }


}


