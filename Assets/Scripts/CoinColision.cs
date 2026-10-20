using UnityEngine;

public class CoinColision : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coins")) {
            ScoreManager.Instance.AddScore(1);
        }
    }
}
        