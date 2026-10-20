using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArrowCollision : MonoBehaviour
{
    [SerializeField] private int health = 1;
    [SerializeField] private TextMeshProUGUI thealth;
    [SerializeField] private Image barraSalud;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            thealth.text = health.ToString();
            Destroy(gameObject);
            barraSalud.fillAmount = health / 10f;
        }

    }
}
