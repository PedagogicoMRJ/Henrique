using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //Variável booleana para identifica o gol do jogador a esquerda
    public bool isPlayerLeftGoal;
    // Variavel que armazena o audio do gol
    public AudioSource audiogoal;

    // A função OnTriggerEnter2D é chamada ao detectar uma colisão entre objetos
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Verifica se o objeto que colidiu possí a tag Ball
        if (collision.gameObject.CompareTag("Ball"))
        // Caso a condição seja verdadeira
        {
            // Aciona o audio do gol
            audiogoal.Play();
            // Verifica se a variável booleana isPlayerLeftGoal NÂO é verdadeira
            if (!isPlayerLeftGoal)
            // Caso a condição seja vedadeira
            {
                // Exibe a mensagem "Player Left Scored" na área de debugs
                Debug.Log("Player Left Scored");
                // Chama a função PlayerLeftScored do script GameManager do objeto GameManager
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLeftScored();
            }
            // Caso a condição seja falsa
            else
            {
                // Exibe a mensagem "Player Left Scored" na área de debugs
                Debug.Log("Player Right Scored");
                //Chaa a função PLayerLeftScored do script GameManager do objeto GameManager
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerRightScored();
            }
        }
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