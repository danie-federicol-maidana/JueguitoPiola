    using UnityEngine;

    public class Jump : MonoBehaviour
    {
        public float velocidad;
        public float fuerzaSalto = 5f;
        public float longitudRayCast = 1.1f;
        public bool enSuelo;
        public LayerMask capaSuelo;
        private Rigidbody2D rb;
        
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRayCast, capaSuelo);
            enSuelo = hit.collider != null;
            if (enSuelo && Input.GetKeyDown(KeyCode.W)){
                rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
            } 
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitudRayCast);
        }
    }
