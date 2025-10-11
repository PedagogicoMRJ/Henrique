using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    // Variável que armazena o valor da velocidade do robô
    public float speed;
    // Variável que armazena o valor da força do pulo do robô
    public float jump;
    // Variável que recebe o componente de física 2D rigidbody
    private Ridigbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        // rig recebe o componente rigidbody do robô
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Chamaa função Movement
        Movement;
        // Chama a função Jump
        Jump();
    }
    // Função que controla o movimento do robô
    void Moviment()
    {
        // Vetor que recebe o pararetro que define a direção do movimento do robô
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        // Altera a posição do robô de acordo com os valores de "moviment" e "speed"
        transform.position += movement * speed * Time.deltaTime;
    }
    // Função que controla o pulo do robô
    void Jump()
    {
        // Verifica que o botão tag "Jump" foi pressionado
        if (Input.GetButton("Jump"))
        {
            // Adiciona impulso ao rigidbody 2D do robô de acordo com o valor de jump
            rig.AddForce(new Vector2(0f, jump ),)
        }
    }

}

