using System.Collections;
using System.Collections.Generic;
//Usa a biblioteca da Unity
using UnityEngine;
//Usa a biblioteca do TextMesh Pro
using TMPro;

public class GameManager : MonoBehaviour
{
    //Texto escrito "Ball"
    [Header("Ball")]
    // Classe que acessa a entidade objeto Ball da Unity
    public GameObject Ball;
    // Texto escrito "Player Left"
    [Header("Player Left")]
    // Classe que acessa a entidade objeto LeftPlayer da Unity
    public GameObject LeftPlayer;
    // Classe que acessa a entidade ojeto LeftGoal da Unity
    public GameObject PlayerLeftGoal;
    // Texto escrito "Player Right"
    public GameObject PlayerLeftText;
    // Classe que acessa a entidade objetoPlayer RightScore da Unity
    [Header("Player Right")]
    // Classe que acessa a entidade objeto RightPlayer a Unity
    public GameObject RightPlayer;
    // Classe que acessa a entidade objeto RightGoal da Unity
    public GameObject PlayerRightGoal;
    // Texto escrito "Score UI"
    [Header("Score UI")]
    // Classe que acessa a entidade objeto PlayerLeftScore da Unity
    private int PlayerLeftScore;
    //Variável que armazena a pontuação do jogador a direita
    private int PlayerRightScore;
    public GameObject PlayerRightText;
    // Variável que armazena a pontuação do jogador a esquerda
    public void PlayerLeftScored()
    {
        // Aumenta o valor contido na variável PlayerLeftScore
        PlayerLeftScore++;
        //Atribui ao texto do objto TMP PLayerLeftScore oo valor da variável PlayerLefScore
        PlayerLeftText.GetComponent<TextMeshProUGUI>().text = PlayerLeftScore.ToString();
        // Chama a função ResetPosition
        ResetPosition();
    }
    // A função ResetPosition chama as funções Reset dos Scripts Ball e Racket
    public void ResetPosition()
    {
        // Chama a função Reset do script Ball do componente Ball
        Ball.GetComponent<Ball>().Reset();
        // Chama a função Reset do script racket do componente LeftPlayer
        LeftPlayer.GetComponent<Racket>().Reset();
        // Chama a função Reset do script Racket do component RightPlayer
        RightPlayer.GetComponent<Racket>().Reset();
    }
    // A função PlayerLeftScore registra que o jogador a esquerda pontuou
    public void PlayerRightScored()
    {
        // Aumenta o valor contido na variável PlayerRightScore
        PlayerRightScore++;
        PlayerRightText.GetComponent<TextMeshProUGUI>().text = PlayerRightScore.ToString();
        // Chama a função ResetPosition
        ResetPosition();
    }
   

    // Update is called once per frame
    void Update()
    {

    }
}
