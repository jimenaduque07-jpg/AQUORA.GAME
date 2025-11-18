using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private bool puedeMover = true; // para evitar movimiento mientras muere


    void Start()
    {
        escalaOriginalX = transform.localScale.x;
    }


    void Update()
    {
        if (!puedeMover) return;

        horizontal = Input.GetAxisRaw("Horizontal");


        tocaSuelo = Physics2D.Raycast(transform.position, Vector3.down, distanciaRayo, capaSuelo);
        Debug.DrawRay(transform.position, Vector3.down * distanciaRayo, Color.red);


        animador.SetBool("isWalking", horizontal != 0);

 
        if (horizontal != 0)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(horizontal) * escalaOriginalX,
                transform.localScale.y,
                transform.localScale.z
            );
        }


        if (Input.GetKeyDown(KeyCode.W) && tocaSuelo)
        {
            Saltar();
        }

  
        animador.SetBool("isJumping", !tocaSuelo);
    }


    void FixedUpdate()
    {
        if (!puedeMover) return;

        rb.velocity = new Vector2(horizontal * velocidad, rb.velocity.y);
    }


    public void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            StartCoroutine(MorirYReiniciar());
        }
    }


    IEnumerator MorirYReiniciar()
    {
        puedeMover = false;


        rb.velocity = Vector2.zero;
        rb.isKinematic = true;



        yield return new WaitForSeconds(0.8f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
