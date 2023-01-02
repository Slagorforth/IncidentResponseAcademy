using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour {

    public Vector2 cameraChange; // Vektor für die Änderung der Kameraposition
    public Vector3 playerChange; // Vektor für die Änderung der Spielerposition
    private CameraMovement cam; // Referenz auf das Kameraskript

    // Use this for initialization
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>(); // Zuweisen der Kamera
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Wird aufgerufen, wenn ein Collider2D den Trigger betritt
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger betritt, das Tag "Player" hat und kein Trigger ist,
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            // werden die minPosition und maxPosition der Kamera um den cameraChange-Vektor erweitert und
            // die position des Spielers um den playerChange-Vektor verändert.
            cam.minPosition += cameraChange;
            cam.maxPosition += cameraChange;
            other.transform.position += playerChange;

        }
    }

}
