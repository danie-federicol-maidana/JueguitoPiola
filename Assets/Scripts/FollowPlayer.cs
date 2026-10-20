    using UnityEngine;

    public class FollowPlayer : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        int speed = 3;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Vector2  direction = (player.transform.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
