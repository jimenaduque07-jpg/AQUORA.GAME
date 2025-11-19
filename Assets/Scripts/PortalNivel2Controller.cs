using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNivel2 : MonoBehaviour
{
    public GameObject panelGanaste;
    public string nombreJugador = "Idle1 1";

    public int cuarzosNecesarios = 12;
    public ControladorDeCuarzos controladorCuarzos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == nombreJugador)
        {
            if (controladorCuarzos != null &&
                controladorCuarzos.cuarzos >= cuarzosNecesarios)
            {
                if (panelGanaste != null)
                {
                    panelGanaste.SetActive(true);
                }

                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log("Necesitas " + cuarzosNecesarios + " cuarzos para activar el portal");
            }
        }
    }

    public void IrAlInicio()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Pagina_principal");
    }
}