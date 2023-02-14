using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeAdjuster : MonoBehaviour
{
    public float desiredWidth = 16f;

    private void Start()
    {
        float currentAspectRatio = (float)Screen.width / (float)Screen.height;
        float desiredAspectRatio = desiredWidth / 9f;

        if (currentAspectRatio >= desiredAspectRatio)
        {
            Camera.main.orthographicSize = desiredWidth / currentAspectRatio / 2f;
        }
        else
        {
            float differenceInSize = desiredAspectRatio / currentAspectRatio;
            Camera.main.orthographicSize = desiredWidth / 2f * differenceInSize;
        }
    }
}

