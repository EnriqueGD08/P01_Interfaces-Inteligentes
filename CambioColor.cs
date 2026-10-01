/**
 * Script que cambia el color de un objeto en intervalos de frames.
 * 
 * Autor: Enrique Gómez Díaz
 * Fecha: 02/10/2026
 */

using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public int framesEntreCambios = 120;

    private Color colorActual;
    private Renderer objetoRenderer;
    private int frameActual;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();

        colorActual = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        AplicarColor();
    }

    void Update()
    {
        frameActual++;

        if (framesEntreCambios <= 0 || frameActual < framesEntreCambios)
        {
            return;
        }

        frameActual = 0;

        colorActual = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        AplicarColor();
    }

    private void AplicarColor()
    {
        if (objetoRenderer != null)
        {
            objetoRenderer.material.color = colorActual;
        }
    }
}
