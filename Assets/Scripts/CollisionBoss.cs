using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBoss : MonoBehaviour
{
    int life = 10;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image vida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
    private void OnCollisionEnter2D(Collision2D boss)
    {
        if (boss.gameObject.CompareTag("Fuego"))
        {
            Destroy(gameObject);
            Destroy(boss.gameObject);
            
        }
    }
}
