using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
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
