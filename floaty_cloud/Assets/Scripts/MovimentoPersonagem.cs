using System.Collections;
using UnityEngine;

public class MovimentoPersonagem : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer SpriteRenderer;

    [SerializeField] private Sprite  SpersonagemParado;
    [SerializeField] private Sprite  SmovimentoPersonagem;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * 150);

            StopAllCoroutines();
            SpriteRenderer.sprite = SmovimentoPersonagem;
            StartCoroutine(MudarSprite());            
        }
    }

    private IEnumerator MudarSprite()
    {
        yield return new WaitForSeconds(1.0f);
        SpriteRenderer.sprite = SpersonagemParado;
    }
}
