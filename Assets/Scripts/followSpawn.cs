    using UnityEngine;

    public class followSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        int speed = 3;
        
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Vector2  direction2 = (player.transform.position - transform.position).normalized;
            transform.Translate(direction2 * speed * Time.deltaTime);
        }
    }
