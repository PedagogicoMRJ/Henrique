using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
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
        }
    }

