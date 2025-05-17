using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Material material;
    private Vector2  offSet;

    [SerializeField][Range(0,1)] private float speed;

    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    //manipula as nuvens do fundo
    void Update()
    {
        offSet.Set(offSet.x + Time.deltaTime * speed, 0);

        material.mainTextureOffset = offSet;

        if(offSet.x >= 1)
        {
            offSet.Set(0,0);
            material.mainTextureOffset = offSet;
        }
    }
}