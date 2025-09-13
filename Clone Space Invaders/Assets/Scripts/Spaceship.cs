using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spaceship : MonoBehaviour
{
    // Campo que recebe o prefab Laser
    public Laser laserPrefab;
    // Variável que armazena o valor que indica se o Laser está ativo
    private bool laserActive;
    // Variável qe armazena a velocidade do Spaceship
    public float speed;
    void Update()
    {
        // Verifica se a tecla A ou o direcional esquerdo foi pressionado
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Manda a Spaceship para esquerda conforme a velocidade
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
            // Verifica se a tecla D ou o direcional direito foi pressionado
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // Manda o Spaceship para a direita conforme a velocidade
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }
        // Verifica se a tecla espaço ou o mouse foram pressionados
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Chama a função Shoot
            Shoot();
        }
    }
    private void Shoot()
    {
        // Verifica se o Laser não está ativo
        if (!laserActive)
        {
            // Cria um objeto do tipo Laser
            Laser laser = Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            // Ativa a ação destroyed do Laser
            laser.destroyed += LaserDestroyed;
            // Torna ativo o Laser
            laserActive = true;
        }
    }
    // Função que indica que o Laser nAo está ativo
    private void LaserDestroyed()
    {
        // Desativa o Laser
        laserActive = false;
    }
    // Função iniciada ao objeto Spaceship colidir com outro objeto para recomeçar o jogo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o Spaceship
        if (collision.gameObject.layer == LayerMask.NameToLayer("Invader") || collision.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
        }

