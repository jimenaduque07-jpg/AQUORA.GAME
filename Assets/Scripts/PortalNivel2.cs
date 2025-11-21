using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNivel2 : MonoBehaviour
{
    public string nombreEscenaSiguiente = "Ecos";
    public ControladorDeCuarzos controlador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Idle1 1") { /* ... */ }
        {
            if (controlador.cuarzos >= 12)
            {
                SceneManager.LoadScene(nombreEscenaSiguiente);
            }
            else
            {
                Debug.Log("Aún no tienes las 12 cuarzos para entrar al portal");
            }
        }
    }
}