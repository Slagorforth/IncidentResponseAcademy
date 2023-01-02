using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Diese Klasse bewegt die Kamera zum Zieltransform und begrenzt ihre Position innerhalb von Max- und Min-Positionen.
public class CameraMovement : MonoBehaviour
{

    // Der Transform, dem die Kamera folgen soll.
    public Transform target;
    // Der Glättungsfaktor, der die Geschwindigkeit der Kamera bestimmt.
    public float smoothing;
    // Die maximale x- und y-Position der Kamera.
    public Vector2 maxPosition;
    // Die minimale x- und y-Position der Kamera.
    public Vector2 minPosition;

    // Use this for initialization
    void Start()
    {

    }

    // Diese Methode wird jedes Frame aufgerufen, nachdem alle anderen Updates ausgeführt wurden.
    void LateUpdate()
    {
        // Wenn die Kameraposition sich vom Zieltransform unterscheidet, wird die Kameraposition angepasst.
        if (transform.position != target.position)
        {
            // Erstellen eines neuen Vektor3 aus der x- und y-Position des Zieltransforms und der z-Position der Kamera.
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            // Begrenzen der x-Position des Vektor3 auf die Min- und Max-Positionen.
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            // Begrenzen der y-Position des Vektor3 auf die Min- und Max-Positionen.
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            // Bewegen der Kamera zur neuen position des Vektor3 mit dem Glättungsfaktor "smoothing".
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
