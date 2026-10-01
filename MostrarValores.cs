/**
 * Script que muestra los valores de dos vectores en la consola.
 * 
 * Autor: Enrique Gómez Díaz
 * Fecha: 02/10/2026
 */

using UnityEngine;

public class MostrarValores : MonoBehaviour
{
    public Vector3 primerVector = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 segundoVector = new Vector3(1.0f, 0.0f, 0.0f);

    void Start()
    {
        Debug.Log($"Primer vector: {primerVector}");
        Debug.Log($"Segundo vector: {segundoVector}");
        Debug.Log($"Magnitud del primer vector: {primerVector.magnitude}");
        Debug.Log($"Magnitud del segundo vector: {segundoVector.magnitude}");
        Debug.Log($"Ángulo entre los vectores: {Vector3.Angle(primerVector, segundoVector)} grados");
        Debug.Log($"Distancia entre los vectores: {Vector3.Distance(primerVector, segundoVector)}");

        if (primerVector.y > segundoVector.y)
        {
            Debug.Log("El primer vector está a una altura mayor.");
        }
        else if (segundoVector.y > primerVector.y)
        {
            Debug.Log("El segundo vector está a una altura mayor.");
        }
        else
        {
            Debug.Log("Ambos vectores están a la misma altura.");
        }
    }
}
