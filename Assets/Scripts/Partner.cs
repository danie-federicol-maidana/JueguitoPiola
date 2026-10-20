using UnityEngine;

public class Partner : Attack
{
    [SerializeField] private int speed;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private Animator animator;
   

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        AttackEnemy();
       
     
    }
    
   
}
