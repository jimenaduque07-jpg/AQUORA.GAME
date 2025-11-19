using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private ControladorDeVidas controlador;

    private void Start()
    {

        controlador = FindObjectOfType<ControladorDeVidas>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            controlador.QuitarVida(1);
            Destroy(this.gameObject);
        }
    }
}
