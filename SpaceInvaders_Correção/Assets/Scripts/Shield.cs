using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Função ativa ao objeto Shield colidir com um objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se a colisão ocorreu com um objeto de layer Invader
        if (collision.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            // Desativa o objeto
            this.gameObject.SetActive(false);
        }
    }
}
