using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float horizontal;
    public Rigidbody2D rb;
    public float fuerzaDeSalto = 10f;
    public float velocidad = 5f;
    public Animator animador;
    public bool tocaSuelo;

    public float distanciaRayo = 0.6f;
    public LayerMask capaSuelo;

    private float escalaOriginalX;

    void Start()
    {
        escalaOriginalX = transform.localScale.x;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        // Rayo al suelo
        tocaSuelo = Physics2D.Raycast(transform.position, Vector3.down, distanciaRayo, capaSuelo);
        Debug.DrawRay(transform.position, Vector3.down * distanciaRayo, Color.red);

        // Animación caminar
        animador.SetBool("isWalking", horizontal != 0);

        // Voltear personaje
        if (horizontal != 0)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(horizontal) * escalaOriginalX,
                transform.localScale.y,
                transform.localScale.z
            );
        }

        // SALTO
        if (Input.GetKeyDown(KeyCode.W) && tocaSuelo)
        {
            Saltar();
        }

        // Animación de salto (se activa cuando NO toca el suelo)
        animador.SetBool("isJumping", !tocaSuelo);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * velocidad, rb.velocity.y);
    }

    public void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
    }
}