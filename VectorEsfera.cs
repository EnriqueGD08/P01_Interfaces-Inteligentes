/**
 * Script que muestra la posición de la esfera en cada frame.
 * 
 * Autor: Enrique Gómez Díaz
 * Fecha: 02/10/2026
 */

using UnityEngine;

public class VectorEsfera : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 posicion = GetComponent<Transform>().position;
        Debug.Log($"Posición de la esfera: {posicion}");
    }
}
