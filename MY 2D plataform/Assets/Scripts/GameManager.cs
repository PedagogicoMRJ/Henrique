using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Importa a biblioteca UI da Unity
using UnityEngine.UI;
// Importa a bibliote SceneManagent
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    // Variável que recebe a pontuação da bateria
    public int totalscore;
    // Variável que armazena o texto do placar
    public Text scoreboard;
    // Variável estática ligada a classe
    public static GameManager access;
    public GameObject gameover; 
    public void ScoreBoard()
    {
        // Variável que armazena o texto do placar
        scoreboard.text = totalscore.ToString();
    }

    // Função que chama o objeto Game Over
    public void GameOver()
    {
        // Ative o objeto Game Over
        gameover.SetActive(true);
    }
    //função que recomeça a cena
    public void Restart()
    {
        // Carrega a cena SampleScene
        SceneManager.LoadScene("SampleScene");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // Permite acessar a classe
        access = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
