using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControladorDeVidas : MonoBehaviour
{
    [Header("Vidas")]
    public int vidas = 3;

    [Header("UI existente")]
    public TextMeshProUGUI marca_vidas;
    public GameObject panelGameOver;

    private void Start()
    {
        if (panelGameOver != null)
            panelGameOver.SetActive(false);
        ActualizarUI();
    }

    public void QuitarVida(int cantidad)
    {
        vidas -= cantidad;
        if (vidas < 0) vidas = 0;
        ActualizarUI();

        if (vidas == 0 && panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }
    }

    void ActualizarUI()
    {
        if (marca_vidas != null)
            marca_vidas.text = vidas.ToString();
    }

    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
