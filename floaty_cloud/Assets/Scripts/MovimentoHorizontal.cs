using UnityEngine;

public class MovimentoHorizontal : MonoBehaviour
{
    [SerializeField][Range(0,2)] private float velocidade;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= -6)
        {
            transform.position -= new Vector3(velocidade * Time.deltaTime, 0, 0);
        }  

        else
        {
            Destroy(gameObject);
        }
        
    }
}
