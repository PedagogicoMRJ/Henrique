using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball :  MonoBehaviour
{
    // Variável que armazena a velocidade da bola
    public float speed;
    // Variável que acessa o componente Rigidbody 2D da bola
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //chama a função launch
        launch();
        
    }

    // a função launch gera o movimento da bola
    private void launch()
    {
        //atribui um valor aleatório de -1 ou 1 a variável x
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        //atribui um valor aleatorio de -1 ou 1 a variável y
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        // atribui á velocidade do componente rigidbody um novo vetor x,y
        rb.velocity = new Vector2(speed * x, speed * y);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
