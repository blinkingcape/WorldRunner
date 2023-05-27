using UnityEngine;

public class PlataformJump : MonoBehaviour {

    public float jumpForce = 10f;
    public Rigidbody rb;

    void OnCollisionEnter(Collision col) {
        // Verifica se o jogador colidiu com uma plataforma
        if (col.gameObject.CompareTag("Plataforma")) {
            // Aplica uma força de salto para o jogador
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}