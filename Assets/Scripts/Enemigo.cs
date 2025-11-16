using UnityEngine;
using TMPro;

public class Enemigo : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int vidasActuales = int.Parse(textoVidas.text);

        vidasActuales--;
        if (vidasActuales < 0) vidasActuales = 0;

        textoVidas.text = vidasActuales.ToString();

        Destroy(this.gameObject);
    }
}