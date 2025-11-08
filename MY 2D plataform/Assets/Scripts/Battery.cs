using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    // Variável que recebe a pontuação da bateria
    public int score;
    // Função chamada ao objeto ser atravessado
    private void OntriggerEnter2D(Collider2D collision)
    {
        // Verifica se objeto que colidiu possui a tag Player
        if(collision.gameObject.tag == "Player")
        {
            // Acessa variável totalscore da classe GmaeManager
            GameManager.access.totalscore += score;
            GameManager.access.ScoreBoard();
            // Destroi o objeto
            Destroy(gameObject);
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
