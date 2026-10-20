using TMPro;
using UnityEngine;


public class Arrow1 : Attack
{
    float speed = 6f;
    [SerializeField] private GameObject arrow2;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private TextMeshProUGUI tlife;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(arrow2, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(-5 * speed * Time.deltaTime,0,0);
       
   }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("Boss"))
        {
            life -= col.gameObject.GetComponent<EnemyCollision2>().Life;
            tlife.text = life.ToString();

        }
    }
   
    
}
