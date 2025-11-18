using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeItem : MonoBehaviour
{
    public int item = 0;

    public void SumarItem()
    {
        item++;
        Debug.Log("Item: " + item);
    }
}