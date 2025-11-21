using TMPro;
using UnityEngine;

public class AumentarNota : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public ControladorDeNota controlador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int puntuacionActual = int.Parse(textoPuntuacion.text);
            puntuacionActual++;
            textoPuntuacion.text = puntuacionActual.ToString();

            controlador.SumarNota();

            Destroy(gameObject);
        }
    }
}