using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    // Classe que acessa a entidade Pipes da Unity
    public GameObject pipe;
    // Variável que armazena a altura do objeto Pipes
    public float height;
    // Variável que armazena o tempo máximo paa um novo objeto do tipo pipe ser criado
    public float maxtime;
    // Variável que armazena o tempo que um objeto permaneceu no jogo
    private float timer  = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // Cria um novo objeto do tipo pipe
        GameObject newPipe = Instantiate(pipe);
        // Altera a posição do novo objeto newPipe para a posição do objeto Pipe somando a um novo vetor (0, =/- height, 0)
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Cria um novo objeto quando timer for maior que maxtime, destroi o objeto depois de 10 segundos e zera o timer
        if (timer > maxtime)
        {
            GameObject newPipe = Instantiate(pipe);
            // Altera a posição do novo objeto newPipe após 10 segundos
            Destroy(newPipe, 10f);
            // Atribuí zero a variável timer
            timer = 0;
        }
        // A cada segundo a variável timer aumenta seu valor
        timer += Time.deltaTime;
    }
}
