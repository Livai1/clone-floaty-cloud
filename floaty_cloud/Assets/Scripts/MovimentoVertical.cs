using UnityEngine;

public class MovimentoVertical : MonoBehaviour
{
    [SerializeField] [Range(0,2)] private float velocidade;

    private enum Direcao{SUBIR, DESCER}

    private Direcao direcaoAtual = Direcao.SUBIR;

    void Start()
    {
        int DirecaoInicial = Random.Range(0,2);

        if(DirecaoInicial == 0)
        {
            direcaoAtual = Direcao.SUBIR;
        }
        else
        {
            direcaoAtual = Direcao.DESCER;
        }
    }

    void Update()
    {
        switch(direcaoAtual)
        {
            case Direcao.SUBIR:
                transform.position += new Vector3(0, velocidade * Time.deltaTime, 0);

                if(transform.position.y > 6)
                {
                    direcaoAtual = Direcao.DESCER;
                }

            break;

            case Direcao.DESCER:
                transform.position -= new Vector3(0, velocidade * Time.deltaTime, 0);

                if(transform.position.y < 6)
                {
                    direcaoAtual = Direcao.SUBIR;
                }

            break;
        }
    }
}
