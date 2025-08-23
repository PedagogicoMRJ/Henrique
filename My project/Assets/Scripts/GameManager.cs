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
    public GameObject PlayerLeftGoal;
    // Texto escrito "Player Right"
    [Header("Player Right")]
    // Classe que acessa a entidade objeto PlayerLeftScore da Unity
    public GameObject PlayerLeftText;
    // Classe que acessa a entidade objetoPlayer RightScore da Unity
    public GameObject PlayerRightText;
    // Variável que armazena a pontuação do jogador a esquerda
    private int PlayerLeftScore;
    // Variável que armazena a pontuação do jogador a direita
    private int PlayerRightScore;
    // Agunção PlyerLeftScore registra que o jogador a esquerda pontuou
    public void PlayerLeftScored()
    {
        // Aumenta o valor contido na variável PlayerLeftScore
        PlayerLeftScore++;
        //Atribui ao texto do objto TMP PLayerLeftScore oo valor da variável PlayerLefScore
        PlayerLeftText.GetComponent<TextMeshProUGUI>().text = PlayerLeftScore.ToString();
    }
    // A função PlayerLeftScore registra que o jogador a esquerda pontuou
    public void PlayerRightScored()
    {
        // Aumenta o valor contido na variável PlayerRightScore
        PlayerRightScore++;
    }
   

    // Update is called once per frame
    void Update()
    {

    }
}
