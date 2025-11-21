using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantiene este objeto al cambiar escenas
        }
        else
        {
            Destroy(gameObject); // Evita duplicados si vuelves a una escena donde existe otro MusicManager
        }
    }
}