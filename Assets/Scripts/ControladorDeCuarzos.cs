using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeCuarzos : MonoBehaviour
{
    public int cuarzos = 0;

    public void SumarCuarzo()
    {
        cuarzos++;
        Debug.Log("Cuarzos: " + cuarzos);
    }
}
