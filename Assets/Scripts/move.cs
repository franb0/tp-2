using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform[] direcciones; // Array de puntos de destino
    public float velocidad = 10f; // Velocidad de movimiento
    public int indexDireccion = 0; // Índice actual en el array de direcciones

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) // Verifica si se mantiene presionada la tecla Espacio
        {
            Moverse(); // Llama a la función Moverse cuando se mantiene presionada la tecla Espacio
        }
    }

    void Moverse()
    {
        if (direcciones.Length == 0) // Verifica si no hay puntos de destino en el array
        {
            return; // Si no hay puntos, sal de la función
        }

        Transform direccionActual = direcciones[indexDireccion]; // Obtiene el punto de destino actual

        // Mueve el objeto hacia el punto de destino actual con una velocidad constante
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, direccionActual.position, velocidad * Time.deltaTime);

        // Verifica si el objeto ha llegado al punto de destino actual
        if (gameObject.transform.position == direccionActual.position)
        {
            indexDireccion++; // Incrementa el índice para pasar al siguiente punto de destino
        }
    }
}
