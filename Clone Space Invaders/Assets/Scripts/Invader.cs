using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    // Objeto privado do tipo SpriteRenderer
    private SpriteRenderer SpriteRenderer;
    // Função chamada quando a instância do script é despertado
    public void Awake()
    {
        // O objeto spriteRenderer recebe o componente SpriteRenderer dos prefabs dos INvaders
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
