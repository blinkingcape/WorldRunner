using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Lava : MonoBehaviour {

    public string ResetScene;
    public Rigidbody rb;

    void OnCollisionEnter(Collision col) {
        // Verifica se o jogador colidiu com MILK
        if (col.gameObject.CompareTag("Lava")) 
        {
            SceneManager.LoadScene (ResetScene);
            Debug.Log("ta funcionado kkk");
        }
    }
}