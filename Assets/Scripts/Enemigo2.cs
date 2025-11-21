using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    private ControladorDeVidas1 controlador;

    private void Start()
    {
        controlador = FindObjectOfType<ControladorDeVidas1>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            controlador.QuitarVida(1);
            Destroy(gameObject);
        }
    }
}

