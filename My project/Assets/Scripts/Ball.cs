using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball :  MonoBehaviour
{
    // Variável que armazena a velocidade da bola
    public float speed;
    // Variável que acessa o componente Rigidbody 2D da bola
    public Rigidbody2D rb;
    // Vetor que armazena a posição inicial x, y, z da bola
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Armazena os valores da posição atual da bolano vetor startPosition
        startPosition = transform.position;
        //chama a função launch
        Launch();
        
    }

    // a função launch gera o movimento da bola
    private void Launch()
    {
        //atribui um valor aleatório de -1 ou 1 a variável x
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        //atribui um valor aleatorio de -1 ou 1 a variável y
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        // atribui á velocidade do componente rigidbody um novo vetor x,y
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    // A função Reset reposiciona a bola em sua posição inicial
    public void Reset()
    {
        // Atribui á velocidade do componente Rigidbody o vetor x=0 y=0
        rb.velocity = Vector2.zero;
        // Atribui os valores arazenados na variavel startPosition a posição inicial da bola 
        transform.position = startPosition;
        // Chama a função Launch
        Launch();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
