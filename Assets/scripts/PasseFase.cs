using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PasseFase : MonoBehaviour {

    public string Scene;
    public Rigidbody rb;

    void OnCollisionEnter(Collision col) {
        // Verifica se o jogador colidiu com MILK
        if (col.gameObject.CompareTag("Milk")) 
        {
            SceneManager.LoadScene (Scene);
            Debug.Log("ta funcionado kkk");
        }
    }
}