using UnityEngine;

public class Attack : MonoBehaviour
{
    // Attack partner = new Attack();
    [SerializeField] private GameObject spawnPoint;
    
    [SerializeField] private GameObject arrow;

    [SerializeField] private Animator animator;
    private IWeapon weapon;
    private IWeapon gun;
    private IWeapon superGun; 
    private IWeapon SpecialGun;
    [SerializeField] private GameObject bulletToFire;

    float speed = 4;
    public int life = 3;
    bool isAttacking;
    int damage = 1;
    int currentWeapon;
    public void AttackEnemy()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Attack");
            Instantiate(arrow, spawnPoint.transform.position, spawnPoint.transform.rotation);
   
        }
    }

       
    
    void Start()
    {   
        animator = GetComponent<Animator>();
        //weapon = new SuperGun();

        gun = new Gun();
        superGun = new SuperGun();
        //SpecialGun = new SpecialGun();
        weapon = gun;

    }
    // Update is called once per frame
    void Update()
    {
        AttackEnemy();

        if (Input.GetKeyDown(KeyCode.Z)) {
            weapon.Shoot(bulletToFire, spawnPoint);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            weapon = superGun;
        }
    }           

    
}   