/*using UnityEngine;
using UnityEngine.Pool;
public class Movement2 : MonoBehaviour
{
    ObjectPool<bulletPlayer> pool;
    bulletPlayer bullet;                        
    [SerializeField] private GameObject bulletToFire;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       pool = new ObjectPool<bulletPlayer>(CreateBullet, ActivateBullet, DesactivateBullet, DestroyBullet, false, 10, 100);
    }
    private void DestroyBullet(bulletPlayer player)
    {
        Destroy(bulletToFire);
    }

    private void DesactivateBullet(bulletPlayer bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    private void ActivateBullet(bulletPlayer bullet)
    {
        bullet.gameObject.SetActive(true);
    }
    private bulletPlayer CreateBullet()
    {
        GameObject obj = Instantiate(bulletToFire);

        bulletPlayer newBullet = obj.GetComponent<bulletPlayer>();

        newBullet.AssignPool(pool);

        return newBullet;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            bulletPlayer newBullet = pool.Get();
            newBullet.transform.position = transform.position;                  
        }   
    }


        

}
*/