using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalCameraFollow : MonoBehaviour
{
    public Transform target;     // El jugador
    public float smoothSpeed = 0.12f;

    public float offsetY = 2f;   // Cuánto más arriba se ve el personaje
    public float fixedX = 0f;    // La X fija donde estará la cámara

    void LateUpdate()
    {
        if (target == null) return;

        // Solo seguir en Y
        float desiredY = target.position.y + offsetY;

        float smoothedY = Mathf.Lerp(transform.position.y, desiredY, smoothSpeed);

        transform.position = new Vector3(
            fixedX,           // X fija
            smoothedY,        // Y sigue al jugador
            transform.position.z
        );
    }
}