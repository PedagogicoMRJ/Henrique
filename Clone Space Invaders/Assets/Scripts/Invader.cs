using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    // Objeto privado do tipo SpriteRenderer
    private SpriteRenderer spriteRenderer;
    // Ação que refere-se a morte do Invader
    public System.Action killed;
    // Função chamada quando a instância do script é despertado
    public void Awake()
    {
        // O objeto spriteRenderer recebe o componente SpriteRenderer dos prefabs dos Invaders
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Função chamada ao objeto Invader colidir co algo
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Verifica se Invader colidiu com um objeto que possuí a layer Laser
        if (collision.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            // Chama a ação killed
            this.killed.Invoke();
            // Desativa o objeto Invader
            this.gameObject.SetActive(false);
        }
    }
}
