using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager instance;
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI tScore;

    public static ScoreManager Instance => instance;
    private int puntos;
    private void Awake()    
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {   
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    

    public void AddScore(int sco)
    {
        score += 10;
        tScore.text = score.ToString();
    }
   
    void Update() {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("EasterEgg");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Videogame");
        }
    }    

}