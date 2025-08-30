using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Variável booleana (recebe apenas um valor que pode ser verdadeiro ou falsa) para identificar o jogador a esuqerda
    public bool isplayerleft;
    //Variável que armazena o valor da velocidade das plataformas dos jogadores
    public float speed;
    // Variável que acessa o componente Rigidbody 2D das plataformas
    public Rigidbody2D rb;
    // Variável que armazena o valor referente aos movmentos das plataformas
    private float movement;
    //Obs: Variáveis pblicas podem ter seus valores alterados diretamente pela Unity
    //Vetor que armazena a posição inicial x,y,z das plataformas dos jogadores
    public Vector3 startPosition;
    // Start is called before the first frame update
    // A função Start é chamado antes do primeiro frame do jogo    
    void Start()
    {
        // Armazena os valores da psição atal da bola no vetor startPosition
        startPosition = transform.position;
    }
    // A função Reset reposicioa as plataformas em sua posição inicial
    public void Reset()
    {
        // Atribui á velocidade do componente Rigidbody o vetor x=0 y=0
        rb.velocity = Vector2.zero;
        // Atribui á velocidade armazenados na variável startPosition a posição atual das plataformas
        transform.position = startPosition;
    }
    // Update is called once per frame
    void Update()
    {
        // verifica se a variável boolena is playerleft é verdadeira
        if (isplayerleft)
            // Caso a variável seja verdadeira

            // armazena o valor da entrega vertical1 na variavel movement
            movement = Input.GetAxisRaw("Vertical1");
        // Caso a variável seja verdadeira
        else{
            // armazena o valor da entrega vertical2 na variavel movement
            movement = Input.GetAxisRaw("Vertical2");
        }
        //Atribui á velocidade do componente rididbody um novo vetor x, y
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
