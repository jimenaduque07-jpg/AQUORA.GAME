using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNivel2Controller : MonoBehaviour
{
    public GameObject panelGanaste;
    public int notaNecesarios = 1;
    public ControladorDeNota controladorNota;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (controladorNota != null &&
                controladorNota.nota >= notaNecesarios)
            {
                if (panelGanaste != null)
                {
                    panelGanaste.SetActive(true);
                }

                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log("Necesitas " + notaNecesarios + " notas para activar el portal");
            }
        }
    }

    public void IrAlInicio()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Pagina_principal");
    }
}