using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Classe que acessa o objeto GameManager
    public GameManager manage;
    // Start is called before the first frame update
    void Start()
    {
        // Associa o objeto GameManager a manage
        manage = FindObjectOfType<GameManager>();
    }
    // Função chamada quando o objeto Scored é atravessado por outro objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Aumenta o valor da variável score de GameManager
        manage.score++;
        // Atribuí o valor de score ao texto scoretext de GameManager
        manage.scoretext.text = manage.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
