    using UnityEngine;

public class Gun : IWeapon
{
    public void Shoot(GameObject bulletToFire, GameObject spawnPoint){
        Object.Instantiate(bulletToFire, spawnPoint.transform.position, spawnPoint.transform.rotation);    
    }
}   
            