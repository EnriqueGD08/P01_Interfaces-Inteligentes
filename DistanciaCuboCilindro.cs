/**
 * Script que calcula y muestra la distancia entre un cubo y un cilindro en cada frame.
 * 
 * Autor: Enrique Gómez Díaz
 * Fecha: 02/10/2026
 */

using UnityEngine;

public class DistanciaCuboCilindro : MonoBehaviour
{
    private Transform transformCubo;
    private Transform transformCilindro;

    void Start()
    {
        GameObject cubo = GameObject.FindGameObjectWithTag("Cube");
        GameObject cilindro = GameObject.FindGameObjectWithTag("Cylinder");

        transformCubo = cubo.GetComponent<Transform>();
        transformCilindro = cilindro.GetComponent<Transform>();
    }

    void Update()
    {
        float distanciaCubo = Vector3.Distance(transform.position, transformCubo.position);
        float distanciaCilindro = Vector3.Distance(transform.position, transformCilindro.position);

        Debug.Log($"Distancia al cubo: {distanciaCubo}");
        Debug.Log($"Distancia al cilindro: {distanciaCilindro}");
    }
}
