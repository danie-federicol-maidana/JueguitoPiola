using TMPro;
using UnityEngine;

public class mainPuntaje : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ScoreManager.Instance.AddScore(1);
    }
}
