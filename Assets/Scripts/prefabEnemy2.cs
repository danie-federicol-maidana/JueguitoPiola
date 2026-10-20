using Newtonsoft.Json.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class prefabEnemy2 : MonoBehaviour
{
    public int speed = 4;
    [SerializeField] private GameObject player;
    [SerializeField] private int health = 10;
    [SerializeField] private TextMeshProUGUI tHealth;
    [SerializeField] private Image bHealth;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Vector2 direction = (player.transform.position - transform.position).normalized;
          transform.Translate(direction * speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            health--;
            tHealth.text = health.ToString();
            bHealth.fillAmount = health / 10f;
            if(health <= 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                Derrota();
            }
        }
    }

    public void Derrota()
    {
      SceneManager.LoadScene("Derrota");
    }
}
