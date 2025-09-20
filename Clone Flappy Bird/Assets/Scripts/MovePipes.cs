using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Variável que armazena a velocidade dos canos
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Modifica a posição do objeto mandando-o para a esquerda de acordo com a velocidade da variável speed
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
