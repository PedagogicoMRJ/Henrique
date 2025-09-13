using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Vetor que recebe a direção do laser
    public Vector3 direction;
    // Variável que armazena a velocidade do laser
    public float speed;
    // Ação publica chamada destroyed;
    public System.Action destroyed;
    void Update()
    {
        //Altera a posição do Laser de acordo com sua direção e a velocidade
        this.transform.position += this.direction * speed * Time.deltaTime;
    }
    // Função ativada ao objeto Laser colidir com outro objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se a ação destroyed é diferente de nulo
        if (this.destroyed != null)
        {
            // Ativa a ação de evento
            this.destroyed.Invoke();
        }
        // Destroi o clone do objeto Laser
        Destroy(this.gameObject);
        
    }
}    