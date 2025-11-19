using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuertePorCaida : MonoBehaviour
{
    [Tooltip("Nombre o índice de la escena del nivel 2")]
    public string nombreNivelActual = "Nivel2"; // o usa Scene build index si prefieres
    [Tooltip("Panel de Game Over que se mostrará cuando vidas = 0")]
    public GameObject panelGameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        // Restar una vida (la variable es estática y persiste entre recargas)
        VidasNivel2.vidas--;

        // Si aún hay vidas...
        if (VidasNivel2.vidas > 0)
        {
            // Recargar el nivel actual (sin tocar VidasNivel2.vidas)
            SceneManager.LoadScene(nombreNivelActual);
        }
        else
        {
            // Vidas llegaron a 0: mostrar panel y resetear las vidas del nivel 2 para la próxima vez
            if (panelGameOver != null)
                panelGameOver.SetActive(true);

            // Reiniciamos las vidas del nivel 2 para la próxima vez que el jugador entre al nivel
            VidasNivel2.vidas = 3;
        }
    }
}

