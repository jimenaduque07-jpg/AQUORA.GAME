using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string nombreEscenaSiguiente = "Lythra";
    public ControladorDeSelnagas controlador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Idle1 1") { /* ... */ }
        {
            if (controlador.selnagas >= 10)
            {
                SceneManager.LoadScene(nombreEscenaSiguiente);
            }
            else
            {
                Debug.Log("Aún no tienes las 10 selnagas para entrar al portal");
            }
        }
    }
}