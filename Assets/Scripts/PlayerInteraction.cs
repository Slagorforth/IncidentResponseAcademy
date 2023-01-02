using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Diese Klasse ermöglicht es dem Spieler, PC-Objekte innerhalb einer bestimmten Distanz zu interagieren, indem er die Taste "E" drückt.
public class PlayerInteraction : MonoBehaviour
{
    // Die Distanz, innerhalb der der Spieler PC-Objekte interagieren kann.
    public float interactionRange = 2.0f;

    private void Update()
    {
        // Prüfen, ob die Taste "E" gedrückt wurde
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Raycast von der Spielerposition in die Blickrichtung erstellen
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            // Raycast ausführen und prüfen, ob ein PC-Objekt getroffen wurde
            if (Physics.Raycast(ray, out hit, interactionRange) && hit.collider.CompareTag("PC"))
            {
                // Interaktion mit dem PC-Objekt ausführen (z.B. Dialog anzeigen oder Daten abrufen)
                Debug.Log("Interagiere mit PC-Objekt");
            }
        }
    }
}

