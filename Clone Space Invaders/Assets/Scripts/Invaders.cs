using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Invaders : MonoBehaviour
{
    // Objeto do tipo Invader que receberá os prefabs dos Invaders
    public Invader[] prefabs;
    // Variável que recebe o número de linhas dos Invaders
    public int rows;
    // Variável que recebe o número de colunas dos Invaders
    public int columns;
    // Variável que recebe a velocidade de movimento dos Invaders
    public float speed;
    // Vetor que armazena a direção do movimento dos Invaders
    private Vector3 direction = Vector2.right;
    // Variável que armazena a taxa de disparo de misseis
    public float missileRate;
    // Campo do tipo Laser para gerar missieis
    public Laser missilePrefabs;
    // Variável que armazena o número de invaders mortos
    public int invadersKilled;
    private void Awake()
    {
        // laço de repetição responsável por poicionar os Invaders nas linhas
        for (int row = 0; row < this.rows; row++)
        {
            // Variável que recebe a largura do Invader em relaço as colunas
            float width = 1.0f * (this.columns - 1);
            // Variável que recebe a altura do Invader e relação as linhas
            float height = 1.0f * (this.rows - 1);
            // Vetor que armazena as coordenadas do centro da matriz de Invaders 
            Vector2 centering = new Vector2(-width / 2, -height / 2);
            // Vetor que armazena as coordenadas das linhas da matriz de Invaders
            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * 0.55f), 0.0f);
            // Laço de repetição responsável por posicionar os Invaders nas colunas
            for (int col = 0; col < this.columns; col++)
            {
                //Variável local do tipo Invader reposável por instanciar os prefabs
                Invader invader = Instantiate(this.prefabs[row], this.transform);
                // Vetor que recebe a posição de rowPosition
                Vector3 position = rowPosition;
                // Vetor que armazena a nova posição na coluna dos Invaders
                position.x += col * 0.85f;
                // Altera a posicão local das linhas e colunas dos Invaders
                invader.transform.localPosition = position;
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // Altera a posição dos ivaders com base na direção e na velocidade dos invaders
        this.transform.position += direction * this.speed * Time.deltaTime;
        // Atribui o valor convertido da câmera do jogo ao vetor leftEdge
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        // Atribui o valor convertido da câmera do jogo ao vetor RightEdge
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        // Altera a direção e altura de cada invader caso atinjam as laterias da tela
        foreach (Transform invader in this.transform)
        {
            // Condição que verifica se os invaders não estão ativos na hierarquia
            if (!invader.gameObject.activeInHierarchy)
            {
                continue;
            }
            // Verifica se a posição se a posição dos invaders é maior que a posição da lateral direita da tela
            if (direction == Vector3.right && invader.position.x >= (rightEdge.x - 0.5f))
            {
                // Chama a função AdvancedRow
                AdvancedRow();
                // Verifica se a posição dos invaders é menor que a posição da lateral esquerda da tela
            }
            else if (direction == Vector3.left && invader.position.x <= (leftEdge.x + 0.5f))
            {
                AdvancedRow();
            }
        }
    }
    // Função que inverte a direção a direção de movento dos invaders e altera suas alturas
    private void AdvancedRow()
    {
        // Inverte o valor da direção dos vinvaders
        direction.x *= -1.0f;
        // Vetor que recebe a posição dos invaders
        Vector3 position = this.transform.position;
        // Altera o valor da coordenada Y do vetor position
        position.y -= 0.2f;
        // Altera a posição dos invaders de acordo com o vetor position
        this.transform.position = position;
    }

    // Função chamada ao iniciar o jogo
private void Start()
{
    // Invoca o método MissileAttack repetidas vezes
    InvokeRepeating(nameof(MissileAttack), Time.deltaTime, 5.0f * Time.deltaTime);
}
    // Função que gerá um novo missil
    private void MissileAttack()
    {
        foreach (Transform invader in this.transform)
        {
            if (!invader.gameObject.activeInHierarchy)
            {
                continue;
            }
            // Verifica se um valor aleatório é menor que 1 dividido pela taxa de misseis
            if (Random.value <= (1.0f / this.missileRate))
            {
                // Instancia um novo missil na posiçã do invader
                Instantiate(this.missilePrefabs, invader.position, Quaternion.identity);
                // Quebra a linha de repetição
                break;
            }
        }
    }
    // Função que aumenta a velocidade dos Invaders quando um deles é morto
    private void InvaderKilled()
    {
        // Aumenta em 0.25 a velocidade dos Invaders
        speed += 0.1f;
        // Diminui em 10 a taxa de misseis
        missileRate -= 10f;
        // Aumenta o numero de invaders morts
        invadersKilled++;
        if (invadersKilled == 27)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}