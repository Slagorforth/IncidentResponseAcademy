using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Diese Klasse repräsentiert einen Vektorwert, der in der Unity-Editor-Oberfläche erstellt werden kann.
// Er wird als ScriptableObject gespeichert und kann von anderen Scripts referenziert werden.
[CreateAssetMenu]
public class VectorValue : ScriptableObject
{

    // Der anfängliche Vektorwert.
    public Vector2 initialValue;
}
