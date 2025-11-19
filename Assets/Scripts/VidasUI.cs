using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VidasUI : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;

    void Update()
    {
        if (textoVidas != null)
            textoVidas.text = VidasNivel2.vidas.ToString();
    }
}

