using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCollision2 : MonoBehaviour
{
    [SerializeField] private int life = 10;
    [SerializeField] private Image barraLive;
    [SerializeField] private TextMeshProUGUI textLifeDemon;

    public int Life
    {
        get { return life; }
        set { life = value; }
    }
    [SerializeField] private TextMeshProUGUI tlife;

    [SerializeField] private Image barraLife;

    [SerializeField] private int speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }
    void Update()
    {
        if(life <= 0)
        {
            
        }

    }
    private void OnCollisionStay2D(Collision2D arrow)
    {
        if (arrow.gameObject.CompareTag("Flecha"))
        {
            life--;
            tlife.text = life.ToString();
            barraLife.fillAmount = life / 10f;
            Destroy(gameObject);
                
         
            
        }
    }
    
}
