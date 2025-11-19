using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeCuarzos : MonoBehaviour
{
    [Header("Cantidad de cuarzos recolectados")]
    public int cuarzos = 0;

    // Llama esta función desde el cuarzo cuando el jugador lo recoja
    public void SumarCuarzo()
    {
        cuarzos++;
        Debug.Log("Cuarzos: " + cuarzos);
    }
}
