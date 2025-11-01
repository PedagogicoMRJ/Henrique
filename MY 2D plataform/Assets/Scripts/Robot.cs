    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    // Verifica que armazena o estado de pulo do robô
    public bool isjumping;
    // Variável que armazena o valor da velocidade do robô
    public float speed;
    // Variável que armazena o valor da força do pulo do robô
    public float jump;
    // Variável que recebe o componente de física 2D rigidbody
    private Rigidbody2D rig;
    // Variável que recebe o componente de animação animator
    private Animator anim;
    void Start()

    {
        // rig recebe o componente rigidbody do robô
        rig = GetComponent<Rigidbody2D>();
        // anim recebe o componente animator do robô
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // Chamaa função Movement
        Movement();
        // Chama a função Jump
        Jump();
    }
    // Função que controla o movimento do robô
    void Movement()
    {
        // Vetor que recebe o pararetro que define a direção do movimento do robô
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        // Altera a posição do robô de acordo com os valores de "moviment" e "speed"
        transform.position += movement * speed * Time.deltaTime;
        // Verifica se o valor da entrada "Horizontal" é diferente de 0
        if (Input.GetAxis("Horizontal")  != 0f)
        {
            // Verifica se o valor da entrada "Horizontal" é maior que 0
            if (Input.GetAxis("Horizontal") > 0f)
                anim.SetBool("walk", true);
            // Altera os eixos do robô para 0, 180, 0
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else    
        {
            // Configura o parametro "walk" da animator como verdaderiro
            anim.SetBool("walk", true);
            // Altera os eixos do robô para 0, 180, 0
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        // Configura o parametro "walk' da animator como falso
        anim.SetBool("walk", false);
    }


    // Função que controla o pulo do robô
    void Jump()

    {
        // Verifica que o botão com a tag "Jump" foi pressionado
        if (Input.GetButtonDown("Jump") && !isjumping)
            // Verifica que o botão tag "Jump" foi pressionado
            if (Input.GetButtonDown("Jump"))
            {
                // Adiciona impulso ao rigidbody 2D do robô de acordo com o valor de jump
                rig.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            }
    }


    // Função ativada ao ocorrer uma colisão


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido possui a layer 6
        if (collision.gameObject.layer == 6)
        {
            // Atribui o valor falso a variavel isjumping
            isjumping = false;
            // Configura o parametro "jump" do animator como falso
            anim.SetBool("jump", false);

        }
    }
    // Função ativa quando para de ocorrer uma colisão
    void OnCollisionExit2D(Collision2D collision)
    {
        // Verifica se o objeto colidido possuí a layer 6
        if (collision.gameObject.layer == 6)
        {
            // Atribui o valor verdadeiro a variavel isjumping
            isjumping = true;
            // Configura o parametro "jump" do animator como verdadeiro
            anim.SetBool("jump", true);
        }
    }
}