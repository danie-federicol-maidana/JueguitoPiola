using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class seguirFuego1 : MonoBehaviour
{
    [SerializeField] private GameObject fuego;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private Image barraVida;
    [SerializeField] private TextMeshProUGUI textoVida;
    int speed = 4;
    int health = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisioEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fuego"))
        {
          
            Destroy(gameObject);
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Derrota();
            }
        }
    }
    public void Derrota() { 
    
    }





    }

