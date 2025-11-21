using UnityEngine;

public class ControladorDeNota : MonoBehaviour
{
    public int nota = 0;

    public void SumarNota()
    {
        nota++;
        Debug.Log("Notas: " + nota);
    }
}