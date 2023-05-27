using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour {

    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 1.0f;

    private bool indoParaA = false;

    void Update () {
        if (indoParaA) {
            transform.position = Vector3.MoveTowards(transform.position, pontoA.position, velocidade * Time.deltaTime);
            if (transform.position == pontoA.position) {
                indoParaA = false;
            }
        } else {
            transform.position = Vector3.MoveTowards(transform.position, pontoB.position, velocidade * Time.deltaTime);
            if (transform.position == pontoB.position) {
                indoParaA = true;
            }
        }
    }
}