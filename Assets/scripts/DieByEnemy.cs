using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DieByEnemy : MonoBehaviour {

    public string ResetScene;
    public Rigidbody rb;

    void OnCollisionEnter(Collision col) {
        // Verifica se o jogador colidiu com Inimigo
        if (col.gameObject.CompareTag("Enemy")) 
        {
            SceneManager.LoadScene (ResetScene);
            Debug.Log("morreste kkk");
        }
    }
}   