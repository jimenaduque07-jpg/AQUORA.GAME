using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Aumentar_Puntos2 : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public string puntuacion_cadena;
    public int puntuacion_entero;
    public ControladorDeNota controlador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        puntuacion_cadena = textoPuntuacion.text;

        puntuacion_entero = int.Parse(puntuacion_cadena);

        puntuacion_entero++;
        puntuacion_cadena = puntuacion_entero.ToString();
        textoPuntuacion.text = puntuacion_cadena;
        controlador.SumarNota();

        Destroy(this.gameObject);
    }

}