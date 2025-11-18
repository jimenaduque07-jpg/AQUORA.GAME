using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Aumentar_Cuarzos : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public ControladorDeCuarzos controlador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Asegurarnos de que colisionó con el jugador (opcional, si quieres)
        // if (!collision.CompareTag("Player")) return;

        // Convertir puntuación actual a número (protección si el texto está vacío)
        int puntosActuales = 0;
        if (!string.IsNullOrEmpty(textoPuntuacion.text))
        {
            int.TryParse(textoPuntuacion.text, out puntosActuales);
        }

        // Sumar 1 cuarzo
        puntosActuales++;

        // Actualizar UI
        textoPuntuacion.text = puntosActuales.ToString();

        // Registrar en el controlador
        if (controlador != null)
            controlador.SumarCuarzo();

        // Destruir el objeto al recogerlo
        Destroy(this.gameObject);
    }
}
