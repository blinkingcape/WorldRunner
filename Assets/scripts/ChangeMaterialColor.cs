using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public Color cor; //Armazena a cor que vamos usar
    public Material material; //Acessa o material

    void Start()
    {
        //Altera a cor do material para a nova selecionada
        material.color = cor;
    }
}
