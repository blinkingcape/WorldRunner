using UnityEngine;
using UnityEngine.AI;

public class EnemyIa : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 200f;
    public float activateRange = 5f;
    
    private Rigidbody rb;
    private Transform player;
    private bool chasing;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update()
    {
        // Checar se está dentro do range de ativação
        if (Vector3.Distance(player.position, transform.position) < activateRange) {
            chasing = true;
        }
        
        // Se estiver perseguindo, seguir o player
        if (chasing) {
            // Encontrar direção para o player
            Vector3 direction = player.position - transform.position;
            direction.y = rb.velocity.y;  // manter velocidade Y atual 
            direction.Normalize();
            
            // Rotacionar na direção do player
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0, rotation.y, 0);
            
            // Mover na direção
            rb.velocity = transform.forward * speed;
        }
    }
}