using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class EnemyCollision : MonoBehaviour, iDamageable
{
    
    public int speed = 2;
    [SerializeField] private int health = 10;
    [SerializeField] private Image barraSalud;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject player2;
    [SerializeField] private TextMeshProUGUI thealth;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.Translate(direction * -speed * Time.deltaTime);


    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
          
            health -= collision.gameObject.GetComponent<Player>().Damage;
            thealth.text = health.ToString();
            barraSalud.fillAmount = health / 10f;
            if (health == 0) {
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

    public void GetParalize()
    {
        speed = 0;  
    }



    public void GetDamage()
    {
        health--;
    }
}
