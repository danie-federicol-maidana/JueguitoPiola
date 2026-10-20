/*using System;
using UnityEngine;
        using UnityEngine.Pool;
        using UnityEngine.SceneManagement;

        public class bulletPlayer : MonoBehaviour
        {
            [SerializeField] private int damage;

            void DestroyBullet()
            {
                pool.Release(this);
                Destroy(gameObject);
            }
            ObjectPool<bulletPlayer> pool;
            float timer;    
            void Start()
            {
                timer += Time.deltaTime;

                if (timer > 3)
                {
                    DestroyBullet();
                }

                transform.Translate(0, 10 * Time.deltaTime, 0);
            }

            private void OnTriggerEnter2D(Collider2D collision)
            {
                /*IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();

                if (damageable != null)
                {
                    damageable.GetDamage();
                    ScoreManager.Instance.AddScore(3);
                }

                IParalized paralizable = collision.gameObject.GetComponent<IParalized>();

                if (paralizable != null)
                {
                    paralizable.GetParalized();
                }

                DestroyBullet();

                
            }

  
*/