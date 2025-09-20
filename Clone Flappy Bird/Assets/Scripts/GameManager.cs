using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Biblioteca que acessa o controle de cenas da Unity
using UnityEngine.SceneManagement;
// Biblioteca que acessa a interface da Unity
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Variável que recebe a pontuação do jogador
    public int score;
    // Texto que exibe a pontuação do jogador
    public Text scoretext;
    // Função que recomeça o jogo
    public void Restart()
    {
        // Carrega a cena 0 do jogo
        SceneManager.LoadScene(0);
        // Ativa o jogo
        Time.timeScale = 1;
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
