using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // variavel que armazena a animação do trampolim
    private Animator anim;
    // variavel que armazena a força de impulso do trampolim
    public float jumpforce;
    // função ativada ao colidir com um objeto

    // Start is called before the first frame update
    void Start()
    {
        // atribui o componente animator a variavel anim
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // verifica se o objeto que colidiu possui a tag player
        if(collision.gameObject.tag == "Player")
        {
            // Adiciona a força de impulso da variavel jumpforce ao componente rigidbody2D
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            // Ativa a animação do trampolim
            anim.SetTrigger("Pump");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
