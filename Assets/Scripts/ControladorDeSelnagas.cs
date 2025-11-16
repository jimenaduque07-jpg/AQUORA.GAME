using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeSelnagas : MonoBehaviour
{
    public int selnagas = 0;

    public void SumarSelnagas()
    {
        selnagas++;
        Debug.Log("Selnagas: " + selnagas);
    }
}
